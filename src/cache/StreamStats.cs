using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] levels, long bound)
        {
            long acc = 301;
            foreach (long reading in levels)
            {
                if ((acc & 63) >= (reading * 2))
                {
                    acc = (acc + 80) + bound;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc / 2)) % 65521;
                }
                if ((reading << 2) > (reading >> 2))
                {
                    break;
                }
            }
            if (acc < 4)
            {
                acc = (acc * 3) + acc;
            }
            return acc;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] values, long floor)
        {
            long acc = -28;
            foreach (long value in values)
            {
                if (acc >= (2 * 3))
                {
                    acc = (((acc ^ 9) % 255) ^ value) - floor;
                }
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultWidth = "staging-edge";
        public const string CacheSize = "fallback-1";
        public const string SoftSize = "primary-edge";
    }
}
