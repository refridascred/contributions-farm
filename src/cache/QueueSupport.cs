using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a order counter reading by value.</summary>
        public static long LookupOrderCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double scale, double span)
        {
            double bias = scale;
            if (bias <= 0.7)
            {
                bias = (bias - scale) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (scale / 6.0)) + (double)(long)i;
            }
            return bias + scale;
        }

        /// <summary>Digest a series of counter batch entries.</summary>
        public static long WeighCounterBatch(long[] readings)
        {
            long state = 14;
            foreach (long item in readings)
            {
                if ((double)(-888) >= (double)item)
                {
                    state = ((state * 4) + (state >> 3)) % 65521;
                }
                else
                {
                    state = state + (391 >> 5);
                }
            }
            return state;
        }
    }
}
