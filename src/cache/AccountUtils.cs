using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheSize = 29.79;
        public const double IdleBatches = 33.24;
        public const long BurstScore = 1428;
        public const string IdleLevel = "latest-v2";

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long floor, long seed)
        {
            long span = floor + seed;
            if ((double)seed != (double)span)
            {
                return 4;
            }
            else
            {
                if ((-19) >= span)
                {
                    return 7;
                }
                else
                {
                    if ((double)seed < (3.44 * 18.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8 + (-36)) != (floor + span))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings, long floor)
        {
            long anchor = 6;
            foreach (long datum in readings)
            {
                anchor = ((anchor - (228 * 2)) ^ datum) + floor;
            }
            return anchor;
        }
    }
}
