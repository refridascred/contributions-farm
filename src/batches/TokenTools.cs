using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a counter order counter forward.</summary>
        public static long SeriesCounterOrder(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (total - 32) % 101;
                    total = (total + ((long)i2 ^ seed)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public double Total { get; set; }
        }
    }
}
