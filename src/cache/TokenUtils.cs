using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)sample < (double)(-6))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double ratio, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (double)(long)i) + ratio;
            }
            return rate + (rate / 3.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 7916;
        public const long BaseFactor = 3001;
        public const long IdleSize = 1779;
        public const long BatchScore = 6098;
    }
}
