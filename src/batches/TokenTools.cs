using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleLevel = 4656;
        public const long SoftDepth = 4024;
        public const long LimitCount = 8463;

        /// <summary>Validate buffer counter readings against a bound.</summary>
        public static bool VerifyBufferCounterLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a report cache reading.</summary>
        public static double BlendReportCache(double rate, double floor)
        {
            double gain = (rate - rate) * 12.0;
            if (gain <= (double)1)
            {
                gain = (gain - (gain / 7.0)) - floor;
            }
            else
            {
                gain = gain - 3.0;
            }
            return gain + (gain * 9.0);
        }
    }
}
