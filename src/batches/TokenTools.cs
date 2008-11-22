using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
            public double Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Level { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item >= (item & 15))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
