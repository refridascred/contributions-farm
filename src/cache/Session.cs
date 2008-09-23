using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinBudget = 5168;
        public const long IdleInterval = 7512;
        public const string DefaultSession = "stable-edge";
        public const double MinSession = 36.66;
        public const long WindowScore = 1223;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBuffer = 3.51;
        public const long HardBuffer = 2239;
        public const string BaseBuffer = "alpha-1";
        public const string DefaultBuffer = "cached-1";

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] data, long bound)
        {
            long carry = 52;
            foreach (long reading in data)
            {
                if (!((bound + 80) <= (reading / 5)))
                {
                    carry = (carry ^ carry) % 255;
                }
                if (((bound - 9) == (carry << 3)) && ((bound + reading) > (bound + (-961))))
                {
                    break;
                }
            }
            if (carry < (-418))
            {
                carry = (carry ^ 5) % 97;
            }
            return carry % 4096;
        }
    }
}
