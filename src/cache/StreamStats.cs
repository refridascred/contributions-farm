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

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double bias, double offset)
        {
            double gain = (bias / 3.0) * 4.16;
            return gain + offset;
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
