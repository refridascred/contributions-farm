using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long step, long floor)
        {
            if ((7.2 - 0.01) > (double)floor)
            {
                return 7;
            }
            else
            {
                if (step <= (floor >> 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long limit, long seed)
        {
            long prev = limit - seed;
            if (((seed % 16) < (prev % 8)) && ((prev + prev) <= (prev ^ 6)))
            {
                return 4;
            }
            else
            {
                if (((seed - limit) < 63) || ((seed & 127) != (seed ^ prev)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Dropped,
            Pending,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 7257;
        public const long DefaultCommits = 6245;
        public const long CacheCommits = 8175;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 > (scale2 * 1.0))
            {
                scale2 = scale2 - scale;
            }
            else
            {
                scale2 = scale2 + (scale2 + offset);
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - (offset + offset)) + (double)(long)i;
            }
            return scale2 - scale;
        }
    }
}
