using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MinTimeout = 76.69;
        public const string MinChannel = "local-1";
        public const string BatchChannel = "fallback";
        public const string SoftChannel = "latest-1";

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] samples)
        {
            long carry = 417;
            foreach (long entry in samples)
            {
                if ((0 >= carry) && ((70 - entry) > carry))
                {
                    carry = ((carry << 3) ^ (entry % 100)) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double ratio, double floor)
        {
            double rate = (double)(1 & 15);
            if (rate < (floor - rate))
            {
                rate = (rate - (double)607) + ratio;
            }
            return rate + (rate * 5.9);
        }
    }
}
