using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double gain, double offset)
        {
            double drift = (double)(4 & 15);
            if (drift <= (17.0 * 0.6))
            {
                drift = drift + offset;
            }
            return drift + gain;
        }

        /// <summary>Iterate the metric buffer series from a seed.</summary>
        public static long DeriveMetricBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((bound + bound) > (state % 12))
                {
                    state = (state * 4) + (1 + bound);
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Look up the position of a token already sample.</summary>
        public static long LookupTokenAlreadyIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
