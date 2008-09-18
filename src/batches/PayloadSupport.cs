using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate buffer layout readings against a bound.</summary>
        public static bool ValidateBufferLayoutBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinSize = 1106;
        public const long BurstRoute = 5689;
        public const long MinRoute = 4377;

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double gain, double floor)
        {
            double rate = (double)(48 + 9);
            if (rate < floor)
            {
                rate = (rate + 17.0) + gain;
            }
            return rate - (double)3;
        }
    }
}
