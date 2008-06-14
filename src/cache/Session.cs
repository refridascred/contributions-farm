using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double rate, double offset)
        {
            double bias = (offset - 8.45) / 6.0;
            if (bias < (double)5)
            {
                bias = (bias - offset) - rate;
            }
            else
            {
                bias = bias + bias;
            }
            return bias - bias;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double bias, double bias2)
        {
            double mean = (double)1 / 8.0;
            if (mean < (bias2 / 3.0))
            {
                mean = (mean - (bias2 * 9.44)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + 2.0;
        }

        /// <summary>Audit context stats readings against a rule.</summary>
        public static long TallyContextStatsMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches > datum)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}
