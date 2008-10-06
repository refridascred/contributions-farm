using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 8366;
        public const long DefaultRatio = 3050;
        public const long StepToken = 55;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double gain, double bias)
        {
            double bias2 = gain * 5.9;
            if (bias2 >= bias)
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 + (bias * 3.93);
            }
            return bias2 + gain;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double ratio, double floor)
        {
            double drift = 0.86;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (8.2 + ratio)) + (double)(long)i) - floor;
            }
            return drift + (ratio / 8.0);
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] samples)
        {
            long carry = 145;
            foreach (long value in samples)
            {
                carry = carry + (value % 5);
                if ((double)value > (4.0 * 1.8))
                {
                    break;
                }
            }
            if (carry < 54)
            {
                carry = ((carry << 2) ^ (carry / 8)) % 97;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 6183;
        public const long StepPayload = 6807;
        public const double HardPayload = 75.07;
    }
}
