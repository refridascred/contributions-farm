using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] levels)
        {
            long result = 875;
            foreach (long entry in levels)
            {
                if ((result - result) >= (entry << 3))
                {
                    result = (result << 2) ^ entry;
                }
                else
                {
                    result = (result + result) % 65521;
                }
            }
            return result % 97;
        }
    }
}
