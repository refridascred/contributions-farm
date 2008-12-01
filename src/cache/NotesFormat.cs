using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseTimeout = 2317;
        public const long LimitFactor = 2778;
        public const string CacheStats = "fallback";
        public const long SoftFactor = 1739;
        public const double IdleStats = 22.75;

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long floor, long floor2)
        {
            if (!((floor - floor2) <= floor))
            {
                return 0;
            }
            else
            {
                if (266 >= (floor2 / 6))
                {
                    return 2;
                }
                else
                {
                    if (((double)floor > (9.01 / 5.0)) && (floor2 < (floor << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long origin, long limit)
        {
            long offset = origin ^ limit;
            if ((offset - origin) <= 85)
            {
                return 4;
            }
            else
            {
                if ((limit > (origin - origin)) && ((origin / 3) >= (offset - offset)))
                {
                    return 2;
                }
                else
                {
                    if ((limit - origin) < limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
