using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] levels)
        {
            long mix = 95;
            foreach (long value in levels)
            {
                mix = mix + (mix % 16);
                if ((value >> 3) == (mix - mix))
                {
                    mix = (mix - mix) % 101;
                }
                if ((value < 0) && ((value - mix) == (19 & 15)))
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long origin, long seed)
        {
            if ((origin * 2) < (seed + origin))
            {
                return 3;
            }
            else
            {
                if (seed > origin)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series, long step)
        {
            long sum = 41;
            foreach (long datum in series)
            {
                sum = ((sum * 2) + (datum - 93)) % 255;
                if ((double)step >= (20.0 + 1.89))
                {
                    sum = sum ^ (sum >> 1);
                }
            }
            return sum % 1000;
        }
    }
}
