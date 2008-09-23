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

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!(sum >= (long)i))
                {
                    sum = ((sum << 3) ^ ((long)i % 5)) % 1000;
                    break;
                }
                if (((origin ^ (long)i) <= origin) || ((sum >> 1) > (origin % 97)))
                {
                    sum = sum - origin;
                    sum = (sum ^ (84 >> 2)) % 65521;
                }
                sum = sum + 3;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

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
