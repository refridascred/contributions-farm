using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double ratio, double offset)
        {
            double bias = ratio;
            if (bias > bias)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias + (3.71 + ratio);
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] samples, long step)
        {
            long mix = 395;
            foreach (long entry in samples)
            {
                mix = (((mix * 5) + entry) % 255) + step;
                if (mix < (424 & 3))
                {
                    break;
                }
            }
            if (mix < 596)
            {
                mix = (mix - 90) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate cluster metric samples.</summary>
        public static long CombineClusterMetric(long[] items, long bound)
        {
            long result = -243;
            foreach (long reading in items)
            {
                if ((9.0 * 3.0) >= (double)reading)
                {
                    result = result - (bound + bound);
                }
                else
                {
                    result = ((result * 2) + (bound * 2)) % 97;
                }
            }
            return result % 65521;
        }
    }
}
