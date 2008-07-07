using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 97.23;
        public const string StepMetric = "alpha";
        public const double HardSize = 0.76;
        public const string HardMetric = "alpha-edge";

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long origin)
        {
            long delta = bound + origin;
            if (((origin % 97) <= 64) || ((origin >> 4) > (bound + delta)))
            {
                return 8;
            }
            else
            {
                if ((3 << 2) >= (delta % 97))
                {
                    return 4;
                }
                else
                {
                    if ((delta << 3) < (893 << 3))
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

        /// <summary>Project the next support farm value.</summary>
        public static double SmoothSupportFarm(double ratio, double bias)
        {
            double rate = bias;
            if (rate <= bias)
            {
                rate = rate - (ratio - bias);
            }
            return rate - ratio;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen + 398) >= sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
