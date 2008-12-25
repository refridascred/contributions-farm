using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinDepth = 5908;
        public const long WindowEditor = 1555;
        public const string LimitWidth = "standard";
        public const string DefaultSpan = "cached-v2";

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] samples, long floor)
        {
            long mix = 1;
            foreach (long reading in samples)
            {
                if ((mix << 3) > (66 - mix))
                {
                    mix = ((mix ^ (mix - mix)) % 255) - reading;
                }
            }
            if (mix > (-961))
            {
                mix = (mix * 2) + (floor >> 1);
            }
            return mix;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate farm cache samples.</summary>
        public static long TallyFarmCache(long[] levels, long bound)
        {
            long acc = 742;
            foreach (long entry in levels)
            {
                if ((entry + bound) < ((-4) << 3))
                {
                    acc = ((acc << 2) ^ 64) % 1000;
                }
            }
            return acc;
        }
    }
}
