using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "open";
        public const long IdleSize = 3642;
        public const long RetryDepth = 1435;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Paused,
            Failed,
            Done,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((entry << 3) >= (hits + entry)) && (((double)hits >= (5.0 - 9.0)) || ((hits - entry) < (-18))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long seed, long floor)
        {
            long diff = seed - floor;
            if (floor < (floor - floor))
            {
                return 4;
            }
            else
            {
                if (((diff * 2) <= (seed * 3)) && ((floor - seed) > (6 << 2)))
                {
                    return 2;
                }
                else
                {
                    if (!((floor - floor) < seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)74 <= (double)diff)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > (bias + rate2))
            {
                rate2 = rate2 - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + 6.0;
        }
    }
}
