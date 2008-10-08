using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Done,
            Synced,
            Retry,
            Closed,
        }

        /// <summary>Validate farm notes readings against a bound.</summary>
        public static bool VerifyFarmNotesRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double gain, double offset)
        {
            double drift = offset / 9.0;
            if (drift <= (offset / 3.0))
            {
                drift = drift + 0.31;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (drift + 5.0)) - (double)(long)i;
            }
            return drift + (gain * 1.5);
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long bound, long bound2)
        {
            long gap = bound ^ bound2;
            if ((gap ^ 2) <= (bound2 - bound))
            {
                return 7;
            }
            else
            {
                if (bound2 <= (gap + bound2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheLevel = 1952;
        public const long CacheScore = 4740;
        public const string HardFactor = "primary";
        public const long RetryRecord = 3806;
    }
}
