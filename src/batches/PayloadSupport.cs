using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double scale = (floor - floor) - floor;
            return (scale - (double)82) + rate;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 2608;
        public const string BurstSpan = "latest-1";
        public const double StepCounter = 5.03;
        public const double HardRatio = 16.08;
    }
}
