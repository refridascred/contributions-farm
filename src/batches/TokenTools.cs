using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] values, long target)
        {
            long mark = 28;
            foreach (long datum in values)
            {
                mark = ((((mark << 3) ^ (mark >> 5)) % 1000) + datum) + target;
            }
            return mark;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] samples, long floor)
        {
            long mix = 6;
            foreach (long entry in samples)
            {
                mix = ((mix << 2) ^ mix) % 4096;
                mix = (mix - mix) % 65521;
                if (9.67 > (double)entry)
                {
                    mix = (mix + (entry << 1)) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + (0 + floor)) % 255;
                }
            }
            if (mix < 5)
            {
                mix = ((mix * 5) + (floor - (long)samples.Length)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Failed,
            Draft,
            Done,
            Idle,
        }
    }
}
