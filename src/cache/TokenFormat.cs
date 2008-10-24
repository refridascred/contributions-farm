using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen <= (long)samples.Length)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Total { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double scale, double span)
        {
            double scale2 = span - 3.0;
            if (scale2 < (scale - 5.51))
            {
                scale2 = scale2 + (scale / 3.0);
            }
            return scale2 - (double)13;
        }
    }
}
