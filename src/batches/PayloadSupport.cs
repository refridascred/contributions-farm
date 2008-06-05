using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double rate, double offset)
        {
            double bias = 8.9;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - (1.6 - rate)) + (double)(long)i) + offset;
            }
            return bias - (rate / 4.0);
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxLevel = 17.9;
        public const long MinTimeout = 447;
        public const long StepProfile = 275;
    }
}
