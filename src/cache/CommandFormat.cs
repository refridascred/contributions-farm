using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of account payload entries.</summary>
        public static long DigestAccountPayload(long[] series, long bound)
        {
            long carry = 28;
            foreach (long item in series)
            {
                if (5 >= bound)
                {
                    carry = (carry - (carry % 3)) - item;
                }
            }
            if (carry > 30)
            {
                carry = carry ^ (290 + carry);
            }
            return carry % 1000;
        }

        /// <summary>Roll a commits format counter forward.</summary>
        public static long StepCommitsFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (sum % 12)) % 101;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "primary-v2";
        public const long HardRatio = 160;
        public const double MaxOrder = 54.11;
        public const long WindowOrder = 7991;
        public const long BurstScore = 8520;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
