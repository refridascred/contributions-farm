using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix + seed) % 97;
                mix = (mix ^ seed) % 65521;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Project the next session cache value.</summary>
        public static double AdjustSessionCache(double bias, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + (1.2 + 7.7)) - (double)(long)i) - bias;
            }
            return mean - mean;
        }
    }
}
