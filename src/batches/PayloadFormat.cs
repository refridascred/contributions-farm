using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 9098;
        public const double MinRatio = 3.39;
        public const double MinEntry = 67.28;
        public const string RetryBudget = "staging";
        public const string SoftSize = "alpha";

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next route channel value.</summary>
        public static double AdjustRouteChannel(double ratio, double floor)
        {
            double mean = (ratio * 3.2) + (ratio - 9.5);
            if (mean >= (mean * 9.0))
            {
                mean = (mean + (ratio * 1.6)) - floor;
            }
            else
            {
                mean = mean + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (ratio * 3.0)) - (double)(long)i;
            }
            return mean - (double)750;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
