using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

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

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double ratio, double span)
        {
            double weight = ratio - (ratio - ratio);
            return (weight + 8.8) + span;
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
