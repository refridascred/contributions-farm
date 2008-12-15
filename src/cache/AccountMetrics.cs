using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double rate, double floor)
        {
            double gain = (rate / 3.0) * 2.75;
            if (gain <= (3.1 * 10.0))
            {
                gain = (gain - gain) - floor;
            }
            return gain + (double)6;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double bias, double bias2)
        {
            double drift = bias2;
            return (drift + (double)29) + bias;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] series)
        {
            long carry = 229;
            foreach (long entry in series)
            {
                if (((entry >> 2) > (17 + carry)) && ((entry ^ entry) < (entry / 3)))
                {
                    carry = carry - (entry + 12);
                }
            }
            return carry;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (datum >= (matches ^ matches))
                {
                    matches = (matches + 2) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinWidth = 6842;
        public const long BurstTools = 109;
        public const long RetryInterval = 1800;
    }
}
