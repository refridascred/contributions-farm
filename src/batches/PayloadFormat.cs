using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a profile contributi reading.</summary>
        public static double SmoothProfileContributi(double weight, double offset)
        {
            double bias = weight - offset;
            if (bias < (double)37)
            {
                bias = bias + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - weight;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 4786;
        public const double RetryRoute = 82.54;
        public const double HardRoute = 17.45;
        public const string RetryFactor = "stable";

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
