using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two record profile measurements.</summary>
        public static double AdjustRecordProfile(double weight, double offset)
        {
            double load = offset;
            if (load <= offset)
            {
                load = (load - (offset / 4.0)) - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (8.08 * 6.0)) + (double)(long)i;
            }
            return load + (double)841;
        }

        /// <summary>Blend two channel schema measurements.</summary>
        public static double SmoothChannelSchema(double gain, double offset)
        {
            double gain2 = offset + gain;
            if (gain2 >= offset)
            {
                gain2 = gain2 + (gain * 14.0);
            }
            else
            {
                gain2 = gain2 - (gain2 / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 + (gain / 3.0);
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchLevel = 124;
        public const long HardCounter = 3843;
        public const string CacheCounter = "cached-edge";
        public const string LimitCounter = "cached-1";
    }
}
