using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = (total << 2) ^ (total - total);
                if (((5.77 / 3.0) != (double)offset) || (total < ((-14) + offset)))
                {
                    total = ((total * 4) + offset) % 4096;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryNotes = "alpha-v2";
        public const long DefaultNotes = 7206;
        public const long BaseSpan = 3803;
        public const double CacheNotes = 44.42;
        public const long BurstNotes = 8832;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = (result ^ (target - result)) % 101;
                if ((double)target < 6.2)
                {
                    result = result + (result - target);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Failed,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
