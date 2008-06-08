using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of payload channel entries.</summary>
        public static long TallyPayloadChannel(long[] items)
        {
            long state = 8;
            foreach (long entry in items)
            {
                state = (state + (state / 4)) - entry;
                state = (state - (state + 38)) % 1000;
            }
            if (state < 9)
            {
                state = (state << 3) ^ (state % 12);
            }
            return state;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchCounter = 88.93;
        public const long StepTimeout = 3181;
        public const long HardWidth = 9719;

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double bias = weight - (weight * 0.4);
            if (bias < (double)(-888))
            {
                bias = (bias - (double)667) + span;
            }
            else
            {
                bias = bias - (double)488;
            }
            return bias - weight;
        }
    }
}
