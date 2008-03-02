using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (double)6)
            {
                bias2 = bias2 - (bias2 - scale);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (bias2 / 5.0)) + (double)(long)i;
            }
            return bias2 - (1.8 + scale);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((seen - datum) <= (9 * 4)))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Paused,
            Stale,
            Failed,
            Idle,
        }
    }
}
