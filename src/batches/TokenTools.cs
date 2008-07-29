using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Synced,
            Done,
            Stale,
            Active,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data, long floor)
        {
            long total = 33;
            foreach (long entry in data)
            {
                if ((entry >> 5) >= (total >> 2))
                {
                    total = ((total - (entry ^ entry)) % 255) + floor;
                    total = total + ((long)data.Length << 2);
                }
                total = total + (total % 100);
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 424;
        public const long DefaultDepth = 9613;
        public const long SoftEntry = 2646;
        public const long BatchEntry = 9741;
    }
}
