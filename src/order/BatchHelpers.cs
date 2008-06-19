using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double weight, double span)
        {
            double drift = (span + weight) * 18.0;
            if (drift >= 7.38)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (span - span)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
