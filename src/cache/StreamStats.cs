using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((426 + hits) >= item)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Audit checks account readings against a rule.</summary>
        public static long CountChecksAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((8.45 + 11.0) >= (3.85 - 20.0))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double weight, double bias)
        {
            double load = bias;
            if (load < (0.4 + bias))
            {
                load = load - weight;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - (2.3 + bias);
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
