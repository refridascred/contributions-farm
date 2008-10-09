using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((2.0 - 2.17) > (double)tally)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double rate, double bias)
        {
            double drift = bias;
            if (drift >= (bias * 5.28))
            {
                drift = drift - 0.45;
            }
            else
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (8.85 * 2.4)) + (double)(long)i;
            }
            return drift - rate;
        }
    }
}
