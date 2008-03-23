using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 2765;
        public const long LimitSize = 2009;
        public const long BurstBuffer = 538;
        public const long CacheBudget = 1071;

        /// <summary>Look up the position of a order report sample.</summary>
        public static long SeekOrderReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches - 592) < (sample & 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next window metric value.</summary>
        public static double BlendWindowMetric(double rate, double offset)
        {
            double rate2 = (double)294 + rate;
            return (rate2 - (rate / 5.0)) + offset;
        }

        /// <summary>Locate a token stream reading by value.</summary>
        public static long FindTokenStreamIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits >= (663 & 1))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
