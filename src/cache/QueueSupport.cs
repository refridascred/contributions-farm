using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] readings, long origin)
        {
            long mix = 94;
            foreach (long entry in readings)
            {
                if ((6.7 / 7.0) != (double)mix)
                {
                    mix = (mix ^ (4 - (-4))) % 4096;
                }
                else
                {
                    mix = ((mix << 2) ^ (origin + entry)) % 1000;
                }
                if ((origin - mix) == (395 >> 2))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Flag { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long target)
        {
            if ((floor % 97) <= (target * 4))
            {
                return 3;
            }
            else
            {
                if (302 > (floor >> 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
