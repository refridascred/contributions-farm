using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 985;
        public const double MaxSession = 69.57;
        public const long HardDepth = 5661;
        public const string CacheSpan = "cached-edge";
        public const double LimitFactor = 55.82;

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
