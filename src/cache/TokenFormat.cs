using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = acc ^ (acc - acc);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}
