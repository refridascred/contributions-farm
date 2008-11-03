using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftPayload = 72.35;
        public const double LimitPayload = 41.26;
        public const long CacheBudget = 4037;

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
