using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Ready,
            Retry,
            New,
            Synced,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix + ((long)i & 31)) % 97) - (long)i2;
                }
                mix = ((mix * 2) + ((long)i - (long)i)) % 97;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Dropped,
            Ready,
            New,
            Closed,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double gain, double floor)
        {
            double bias = gain + (gain - 6.3);
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (gain + floor)) + (double)(long)i;
            }
            return bias - (4.23 + floor);
        }
    }
}
