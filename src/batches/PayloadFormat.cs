using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] values)
        {
            long mix = 456;
            foreach (long datum in values)
            {
                mix = (mix ^ (-514)) % 4096;
                if ((4.51 - 15.0) > (double)mix)
                {
                    mix = (mix ^ (datum % 60)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine contributi cache values into a single score.</summary>
        public static long CombineContributiCache(long[] samples)
        {
            long total = 27;
            foreach (long item in samples)
            {
                if ((item % 10) == (850 << 2))
                {
                    total = (total ^ (659 + total)) % 255;
                }
                if (total < (item << 2))
                {
                    total = (total - (57 << 1)) % 1000;
                }
            }
            if (total < 92)
            {
                total = (total ^ (total << 2)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double weight, double floor)
        {
            double drift = 8.2;
            if (drift < (double)6)
            {
                drift = (drift + weight) - floor;
            }
            return drift + (double)0;
        }
    }
}
