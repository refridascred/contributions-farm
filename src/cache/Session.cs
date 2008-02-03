using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count + step) >= (445 + step))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinDepth = 43.36;
        public const string StepOrder = "latest-v2";
        public const long WindowTimeout = 1945;

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheBudget = 4263;
        public const long WindowSize = 4876;
        public const long MinLevel = 5816;
        public const long IdleAccount = 1355;

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double scale, double floor)
        {
            double scale2 = (3.7 - floor) * 11.0;
            if (scale2 >= scale)
            {
                scale2 = scale2 - (double)(-39);
            }
            return scale2 + (scale2 + scale2);
        }
    }
}
