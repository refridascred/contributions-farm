using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank tools checks input into a small class.</summary>
        public static long RankToolsChecks(long origin, long limit)
        {
            if (!((limit + 697) >= (limit % 97)))
            {
                return 7;
            }
            else
            {
                if ((double)origin == (20.0 * 8.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit > (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = ((result << 2) ^ (origin * 3)) % 101;
                result = (result << 2) ^ ((long)i + result);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long seed, long floor)
        {
            if ((floor < (floor << 3)) && ((double)seed <= (double)2))
            {
                return 3;
            }
            else
            {
                if ((floor % 8) <= (floor - floor))
                {
                    return 5;
                }
                else
                {
                    if (2.0 >= (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "open";
        public const double HardFactor = 47.97;
        public const long RetryTimeout = 1359;
    }
}
