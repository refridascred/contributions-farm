using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Synced,
            Stale,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a cluster queue reading by value.</summary>
        public static long FindClusterQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double bias, double bias2)
        {
            double bias3 = 3.0;
            if (bias3 > bias3)
            {
                bias3 = bias3 - bias3;
            }
            for (int i = 0; i < 2; i++)
            {
                bias3 = (bias3 - (bias2 + bias)) + (double)(long)i;
            }
            return bias3 + 17.0;
        }
    }
}
