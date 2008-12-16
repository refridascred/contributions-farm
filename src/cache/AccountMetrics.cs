using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long seed, long origin)
        {
            if ((seed * 4) <= (origin - origin))
            {
                return 1;
            }
            else
            {
                if (!((double)seed < 9.6))
                {
                    return 2;
                }
                else
                {
                    if ((origin + seed) >= (2 + 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftTimeout = 35.85;
        public const long BatchMetrics = 3218;
        public const double WindowMetrics = 96.59;
        public const long LimitScore = 4830;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits / 3) == (cell + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] readings, long target)
        {
            long acc = -9;
            foreach (long value in readings)
            {
                acc = ((acc + (target + 144)) % 65521) - value;
            }
            return acc;
        }
    }
}
