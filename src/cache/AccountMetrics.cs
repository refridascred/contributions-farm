using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] samples, long floor)
        {
            long result = 8;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ (result & 15)) + floor;
                if (!(cell < (result >> 5)))
                {
                    result = (result * 2) + result;
                }
            }
            return result;
        }

        /// <summary>Measure how many batch commits samples are out of range.</summary>
        public static long MeasureBatchCommitsMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum + bound) > (bound - datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Closed,
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] samples, long step)
        {
            long acc = 73;
            foreach (long value in samples)
            {
                acc = ((acc + step) % 1000) - value;
            }
            return acc;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item / 4) < (73 - item))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
