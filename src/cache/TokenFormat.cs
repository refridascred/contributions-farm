using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double RetrySpan = 90.36;
        public const double LimitSpan = 54.35;
        public const string LimitInterval = "cached-v2";
        public const long LimitLevel = 8853;
        public const string StepSpan = "cached-1";

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultRatio = 7836;
        public const string WindowTools = "standard-edge";
        public const long DefaultTools = 2091;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(step > (count + item)) && ((7.9 * 2.0) > (double)step))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
