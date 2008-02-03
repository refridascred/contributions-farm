using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine queue record values into a single score.</summary>
        public static long FoldQueueRecord(long[] samples)
        {
            long result = 143;
            foreach (long sample in samples)
            {
                if (!((result & 15) >= (result ^ sample)))
                {
                    result = result + (result + 2);
                }
            }
            if (result > 9)
            {
                result = result ^ (98 / 3);
            }
            return result % 65521;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
