using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepScore = "stable";
        public const double BatchTimeout = 54.44;
        public const long BaseWidth = 2152;
        public const long LimitCluster = 2816;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinSession = "alpha";
        public const double StepBudget = 1.27;
        public const long HardCount = 5950;
        public const string DefaultSession = "fallback";

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 >= (double)9)
            {
                scale2 = scale2 - (double)(-320);
            }
            else
            {
                scale2 = scale2 - (span + scale);
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 + (span - scale2);
        }
    }
}
