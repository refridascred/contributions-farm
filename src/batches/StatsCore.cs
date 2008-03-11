using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultBudget = 5971;
        public const double CacheBudget = 16.79;
        public const string HardRatio = "latest";

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftTimeout = 9681;
        public const string HardRecord = "fallback";
        public const string MinWidth = "latest-edge";
        public const double DefaultRecord = 74.66;
        public const double LimitRecord = 25.02;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Active,
            Paused,
            Queued,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank metrics tools input into a small class.</summary>
        public static long BucketMetricsTools(long floor, long seed)
        {
            if (((floor << 3) <= floor) || ((floor >> 4) < (seed / 6)))
            {
                return 6;
            }
            else
            {
                if ((double)floor <= (2.0 / 9.0))
                {
                    return 3;
                }
                else
                {
                    if ((seed + floor) != (floor + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
