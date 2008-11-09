using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double StepWidth = 80.57;
        public const string MinMetric = "latest";
        public const long LimitRatio = 9992;
        public const string BurstLevel = "local-edge";
        public const string BatchLevel = "stable-edge";

        /// <summary>Validate stats support readings against a bound.</summary>
        public static bool GuardStatsSupportBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double bias, double floor)
        {
            double bias2 = (double)(39 - 91);
            if (bias2 > (double)62)
            {
                bias2 = (bias2 + bias2) - floor;
            }
            else
            {
                bias2 = bias2 - (bias / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (double)(-387)) + (double)(long)i;
            }
            return bias2 - bias2;
        }
    }
}
