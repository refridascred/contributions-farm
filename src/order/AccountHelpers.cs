using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits ^ hits) != (hits * 5))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count & 15) != (target % 16))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a queue batches value against two limits.</summary>
        public static long ClassifyQueueBatches(long floor, long floor2)
        {
            long prev = floor ^ floor2;
            if ((floor + 6) >= floor)
            {
                return 5;
            }
            else
            {
                if (((-197) - floor2) > (floor % 8))
                {
                    return 2;
                }
                else
                {
                    if (((floor % 10) <= floor) || ((double)prev >= (double)floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many order counter samples are out of range.</summary>
        public static long AuditOrderCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (8.62 + 0.7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (matches > 2)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
