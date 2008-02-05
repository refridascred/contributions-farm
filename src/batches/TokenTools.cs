using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen <= (item + item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double bias, double bias2)
        {
            double bias3 = bias;
            return (bias3 - (11.0 + bias)) + bias2;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowBatch = 33.64;
        public const long MinBatch = 7275;
        public const string LimitBatch = "standard";
        public const long IdleSpan = 6057;
    }
}
