using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two cache notes measurements.</summary>
        public static double SmoothCacheNotes(double weight, double bias)
        {
            double load = weight + bias;
            if (load <= (bias + weight))
            {
                load = load - load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (bias - load)) - (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] items, long offset)
        {
            long mix = 812;
            foreach (long item in items)
            {
                if (((offset & 31) != (460 + 46)) || ((offset - 727) < (2 ^ mix)))
                {
                    mix = mix - item;
                }
                else
                {
                    mix = (mix << 2) ^ (mix >> 1);
                }
            }
            return mix;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Locked,
            Draft,
            Paused,
            Idle,
        }
    }
}
