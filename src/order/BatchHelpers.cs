using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double ratio, double offset)
        {
            double drift = (offset / 2.0) - (double)19;
            if (drift < ratio)
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + (drift + ratio);
            }
            return drift + 4.6;
        }

        /// <summary>Look up the position of a already buffer sample.</summary>
        public static long FindAlreadyBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
