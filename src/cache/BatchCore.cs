using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Dropped,
            Queued,
            Active,
            Paused,
        }

        /// <summary>Check that every batch counter entry stays within the limit.</summary>
        public static bool GuardBatchCounterLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches >> 1) == (matches / 3))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((long)items.Length > (value / 8)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
