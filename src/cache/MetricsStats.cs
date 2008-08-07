using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Paused,
            Queued,
            Active,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)tally > 3.0)
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long offset, long limit)
        {
            if ((limit >> 5) == (5 >> 1))
            {
                return 4;
            }
            else
            {
                if ((double)offset > (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every cache queue entry stays within the limit.</summary>
        public static bool GuardCacheQueueLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample / 3) <= 87)
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }
    }
}
