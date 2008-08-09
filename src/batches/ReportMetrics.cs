using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            Active,
            Ready,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public double Size { get; set; }
        }
    }
}
