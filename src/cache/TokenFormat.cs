using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((hits + datum) > (hits + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public long Total { get; set; }
        }
    }
}
