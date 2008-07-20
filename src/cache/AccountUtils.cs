using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "strict-edge";
        public const double WindowRatio = 88.21;
        public const long MinRatio = 6087;
        public const long CacheInterval = 4057;
        public const string BaseSize = "primary-v2";

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double ratio, double span)
        {
            double ratio2 = 19.0;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (((ratio2 + 5.48) + (double)(long)i) + ratio) - span;
            }
            return ratio2 - ratio2;
        }
    }
}
