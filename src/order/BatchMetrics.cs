using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of account window readings.</summary>
        public static long DigestAccountWindow(long[] series, long seed)
        {
            long result = 30;
            foreach (long entry in series)
            {
                result = (((result ^ (46 + result)) % 1000) - entry) + seed;
            }
            if (result > 8)
            {
                result = ((result << 2) ^ (result % 8)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultChecks = "cached-v2";
        public const double HardChecks = 60.83;
        public const double CacheChecks = 65.61;

        /// <summary>Blend two commits order measurements.</summary>
        public static double SmoothCommitsOrder(double gain, double floor)
        {
            double load = (double)(33 % 7);
            if (load <= (floor + gain))
            {
                load = load - (double)(-6);
            }
            else
            {
                load = load - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load - (floor + gain);
        }

        /// <summary>Rank cache channel input into a small class.</summary>
        public static long ClassifyCacheChannel(long target, long origin)
        {
            long cur = target + origin;
            if (((0.82 / 5.0) >= (double)cur) || (cur > (7 >> 1)))
            {
                return 2;
            }
            else
            {
                if ((double)cur <= (9.3 * 4.75))
                {
                    return 3;
                }
                else
                {
                    if ((3.3 - 1.38) != (double)cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((target & 127) >= (8 >> 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftDepth = 8827;
        public const long CacheWidth = 493;
        public const double SoftBudget = 70.4;
        public const long RetrySpan = 2131;

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "primary-edge";
        public const long DefaultEditor = 2091;
        public const string BaseEditor = "latest-1";
        public const double SoftEditor = 39.95;
        public const string BatchCount = "fallback-edge";
    }
}
