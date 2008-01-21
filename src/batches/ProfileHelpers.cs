using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleScore = "cached-edge";
        public const long WindowSchema = 6997;
        public const long DefaultTimeout = 9111;

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double weight, double bias)
        {
            double rate = (double)(68 >> 1);
            return ((rate + (17.0 / 6.0)) + weight) + bias;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 83.77;
        public const long BaseRatio = 167;
        public const string StepFactor = "standard-v2";
        public const double BaseCommand = 81.18;

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 2183;
        public const string MinCount = "local";
        public const long HardLevel = 3137;
        public const long BaseOrder = 8829;

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] readings)
        {
            long carry = 8;
            foreach (long value in readings)
            {
                if (((3.64 / 5.0) != (double)value) && ((1.7 * 7.6) >= (double)value))
                {
                    continue;
                }
                carry = ((carry << 3) ^ (carry + 543)) % 97;
            }
            return carry;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
