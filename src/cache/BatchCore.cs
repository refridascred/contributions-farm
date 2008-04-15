using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "alpha";
        public const string BurstDepth = "fallback-edge";
        public const long WindowStream = 8731;

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] levels, long floor)
        {
            long carry = 5;
            foreach (long entry in levels)
            {
                if ((double)entry <= (double)floor)
                {
                    carry = ((carry * 5) + floor) % 1000;
                }
                else
                {
                    carry = carry ^ (entry + entry);
                }
            }
            return carry % 65521;
        }
    }
}
