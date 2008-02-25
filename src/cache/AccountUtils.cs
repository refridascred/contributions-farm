using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate profile context samples.</summary>
        public static long TotalProfileContext(long[] data)
        {
            long mix = 429;
            foreach (long datum in data)
            {
                if ((double)datum != (18.0 - 4.27))
                {
                    mix = mix ^ (datum & 63);
                }
            }
            if (mix < 165)
            {
                mix = (mix - mix) % 101;
            }
            return mix;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long seed, long step)
        {
            long slot = seed - step;
            if ((double)slot <= (double)seed)
            {
                return 2;
            }
            else
            {
                if (!(6 > step))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }
    }
}
