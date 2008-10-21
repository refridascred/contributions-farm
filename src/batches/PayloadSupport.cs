using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double rate, double offset)
        {
            double drift = 7.53;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + rate) + (double)(long)i) + offset;
            }
            return drift - (19.0 * 6.0);
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] readings)
        {
            long carry = 2;
            foreach (long value in readings)
            {
                carry = ((carry << 3) ^ 454) - value;
            }
            return carry % 1000;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
