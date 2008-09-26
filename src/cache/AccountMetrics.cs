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

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] samples)
        {
            long mix = -63;
            foreach (long entry in samples)
            {
                if ((double)entry < (10.0 - 6.0))
                {
                    mix = (mix ^ 17) % 97;
                }
            }
            if (mix > 29)
            {
                mix = ((mix * 4) + (mix + mix)) % 255;
            }
            return mix;
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
