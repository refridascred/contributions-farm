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

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                double bias = (20.0 * 16.0) * 9.0;
                if ((((long)i * 3) <= result) || (bias <= (double)9))
                {
                    continue;
                }
                if (((bias - bias) <= (bias * 8.7)) && ((double)result > (double)bound))
                {
                    result = (result ^ bound) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
