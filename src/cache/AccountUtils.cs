using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double span)
        {
            double weight = span;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (weight / 7.0)) + (double)(long)i;
            }
            return weight + ratio;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseTimeout = 6395;
        public const long MaxTimeout = 9345;
        public const long BaseDepth = 477;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
