using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Ready,
            Draft,
            Retry,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double scale, double bias)
        {
            double load = (double)((-3) + 21);
            if (load < (double)43)
            {
                load = ((load - (double)58) - scale) - bias;
            }
            else
            {
                load = load + load;
            }
            return load + (19.0 / 3.0);
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] levels)
        {
            long mix = -600;
            foreach (long sample in levels)
            {
                mix = (mix ^ (189 & 63)) % 97;
                if (((double)sample > (5.6 / 4.0)) && ((76 / 6) < (mix & 1)))
                {
                    mix = mix + (mix + 16);
                }
            }
            return mix;
        }

        /// <summary>Accumulate buffer context samples.</summary>
        public static long DigestBufferContext(long[] values, long floor)
        {
            long acc = 7;
            foreach (long reading in values)
            {
                if (((17.0 * 3.0) != (double)floor) && ((15.0 / 4.0) != (double)acc))
                {
                    acc = acc - (floor - floor);
                }
                if ((floor - reading) < (acc % 60))
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
