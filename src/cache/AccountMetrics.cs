using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 4630;
        public const long MinBuffer = 9536;
        public const long DefaultWidth = 5023;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 1771;
        public const long BatchCount = 2443;
        public const long WindowTimeout = 8175;
        public const long SoftBudget = 7663;

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long floor, long limit)
        {
            long span = floor + limit;
            if ((limit + floor) >= (202 * 5))
            {
                return 6;
            }
            else
            {
                if ((floor < (floor + 888)) || (floor <= (limit / 3)))
                {
                    return 4;
                }
                else
                {
                    if ((limit - span) > (298 & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 4474;
        public const long IdleEditor = 2641;
        public const double WindowFactor = 51.07;
        public const long MinEditor = 2323;
        public const string BaseCount = "fallback-edge";

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long seed, long limit)
        {
            long lane = seed - limit;
            if (lane <= ((-86) % 12))
            {
                return 4;
            }
            else
            {
                if ((seed > limit) && ((lane - limit) < limit))
                {
                    return 3;
                }
                else
                {
                    if (((double)lane <= (3.0 - 4.0)) || ((double)lane != (double)2))
                    {
                        return 7;
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
