using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Synced,
            Retry,
            Stale,
            Active,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] series, long seed)
        {
            long total = 48;
            foreach (long sample in series)
            {
                total = (total ^ (8 + 85)) - seed;
                if ((sample - sample) > total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
