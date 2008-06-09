using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] values, long target)
        {
            long mix = 25;
            foreach (long value in values)
            {
                if ((double)mix < (17.0 - 4.96))
                {
                    mix = (mix - (mix * 5)) + target;
                }
                else
                {
                    mix = mix ^ (value ^ value);
                }
            }
            return mix;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long floor, long seed)
        {
            long step = floor ^ seed;
            if ((seed + floor) >= step)
            {
                return 3;
            }
            else
            {
                if (!((double)seed <= (8.44 + 7.32)))
                {
                    return 0;
                }
                else
                {
                    if ((floor >> 1) >= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinLevel = "local-edge";
        public const string BaseFactor = "fallback-edge";
        public const long MaxRatio = 8471;
        public const double BaseSize = 66.24;
        public const long BatchSize = 7570;
    }
}
