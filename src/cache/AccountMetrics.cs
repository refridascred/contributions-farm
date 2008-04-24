using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double gain, double floor)
        {
            double gain2 = (double)599;
            return ((gain2 + (double)7) + gain) + floor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 4799;
        public const double MaxChannel = 6.63;
        public const double IdleChannel = 9.22;
        public const double BurstSpan = 62.5;
        public const string RetryBudget = "primary-v2";

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry + matches) < ((long)data.Length + entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the counter queue series from a seed.</summary>
        public static long SeriesCounterQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((7.03 * 8.35) <= (double)item) || ((count * 2) != (item << 2)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
