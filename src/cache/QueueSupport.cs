using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double offset)
        {
            double drift = (double)(4 % 3);
            if (drift < (double)7)
            {
                drift = (drift - (double)45) - offset;
            }
            return drift + gain;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] items, long floor)
        {
            long mix = 353;
            foreach (long item in items)
            {
                mix = (mix + mix) + item;
            }
            if (mix > 37)
            {
                mix = mix ^ floor;
            }
            return mix;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
