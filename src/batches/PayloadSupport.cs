using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseCount = 4336;
        public const string SoftStream = "strict-1";
        public const string MaxInterval = "cached";
        public const string WindowStream = "fallback";
        public const long BaseStream = 1490;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits > (seed + hits)) && ((97 - hits) <= (hits + seed)))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
