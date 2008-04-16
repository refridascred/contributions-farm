using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long target)
        {
            if ((floor & 63) >= (floor & 7))
            {
                return 4;
            }
            else
            {
                if (!((floor + floor) >= (target - 9)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

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

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchFactor = 42.93;
        public const long DefaultFactor = 1042;
        public const long MaxAlready = 7183;
        public const string DefaultAlready = "staging-1";
        public const string BatchSize = "alpha-edge";
    }
}
