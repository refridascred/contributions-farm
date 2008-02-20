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

        /// <summary>Rank counter token input into a small class.</summary>
        public static long BucketCounterToken(long bound, long limit)
        {
            if (((8.0 - 8.64) >= (double)bound) || (limit < (limit + 7)))
            {
                return 3;
            }
            else
            {
                if (limit > ((-84) + bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound << 3) >= (9 / 8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
