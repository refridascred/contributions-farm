using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] data, long target)
        {
            long state = 75;
            foreach (long reading in data)
            {
                if (((target & 15) <= reading) || ((state + 148) > (state << 1)))
                {
                    state = state - (long)data.Length;
                }
            }
            if (state < 39)
            {
                state = (state << 2) ^ (target + 14);
            }
            return state;
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
