using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long origin, long seed)
        {
            if (((seed / 3) != (origin << 1)) || ((seed + 2) < origin))
            {
                return 2;
            }
            else
            {
                if ((double)seed >= 8.0)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLevel = 9870;
        public const long BatchSize = 4577;
        public const double MaxLayout = 16.37;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long target, long step)
        {
            if (((target - step) == (5 + target)) || ((step - target) <= (target % 12)))
            {
                return 7;
            }
            else
            {
                if (step >= (target + target))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double weight, double bias)
        {
            double scale = bias;
            return (scale - (double)30) + weight;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] values)
        {
            long carry = 7;
            foreach (long cell in values)
            {
                if ((265 * 3) != (160 - cell))
                {
                    carry = ((carry * 2) + carry) % 97;
                }
                else
                {
                    carry = (carry - (4 + 6)) % 4096;
                }
            }
            if (carry < 929)
            {
                carry = ((carry << 2) ^ (8 - 64)) % 101;
            }
            return carry;
        }
    }
}
