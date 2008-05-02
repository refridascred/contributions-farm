using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session metrics value from a seed.</summary>
        public static long DeriveSessionMetrics(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
