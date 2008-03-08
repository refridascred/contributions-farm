using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "legacy";
        public const long DefaultBudget = 8752;
        public const string CacheSize = "stable-v2";
        public const long CacheBudget = 7099;
        public const long CacheStream = 3230;

        /// <summary>Scale a token tools figure with a bias.</summary>
        public static double SmoothTokenTools(double bias, double bias2)
        {
            double bias3 = (8.7 / 5.0) + (bias2 + 20.0);
            if (bias3 >= (double)15)
            {
                bias3 = bias3 + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias3 = bias3 + (double)(long)i;
            }
            return bias3 - bias;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long step, long bound)
        {
            if ((double)step <= (10.0 - 8.5))
            {
                return 8;
            }
            else
            {
                if ((280 * 4) <= (bound / 2))
                {
                    return 2;
                }
                else
                {
                    if ((step & 3) > step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)step == (18.0 - 18.0)) || (step >= (bound % 8)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
