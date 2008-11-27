using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinDepth = 8759;
        public const long MinInterval = 2995;
        public const long BurstQueue = 3124;
        public const long IdleQueue = 24;
        public const string BatchBudget = "staging-edge";

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double gain, double bias)
        {
            double rate = (double)(52 - (-80));
            if (rate <= (gain - gain))
            {
                rate = rate - rate;
            }
            return rate - (rate + bias);
        }

        /// <summary>Derive the next farm entry value from a seed.</summary>
        public static long SeriesFarmEntry(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = sum ^ (39 << 1);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
