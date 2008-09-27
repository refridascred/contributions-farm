using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double ratio, double offset)
        {
            double load = offset * 5.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + offset) + (double)(long)i) - ratio;
            }
            return load - (double)5;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Paused,
            Ready,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
