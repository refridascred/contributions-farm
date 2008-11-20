using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] items, long floor)
        {
            long score = 8;
            foreach (long sample in items)
            {
                score = (((score * 4) + (floor + score)) % 4096) ^ sample;
            }
            return score % 97;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double weight, double bias)
        {
            double weight2 = (double)(36 >> 2);
            if (weight2 <= weight)
            {
                weight2 = weight2 + (9.64 + bias);
            }
            else
            {
                weight2 = weight2 + (double)513;
            }
            return weight2 - bias;
        }

        /// <summary>Rank buffer editor input into a small class.</summary>
        public static long GradeBufferEditor(long seed, long target)
        {
            long prev = seed + target;
            if (((5.1 + 2.0) < (double)prev) && ((seed << 3) <= (seed + (-7))))
            {
                return 5;
            }
            else
            {
                if ((0 - 48) == (target << 2))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate token checks samples.</summary>
        public static long FoldTokenChecks(long[] values)
        {
            long carry = 811;
            foreach (long sample in values)
            {
                if ((720 + carry) > ((-151) << 1))
                {
                    carry = (carry - (70 + sample)) % 1000;
                }
                if (!((15.0 + 18.0) == (double)sample))
                {
                    break;
                }
            }
            if (carry > 590)
            {
                carry = carry ^ (722 % 2);
            }
            return carry % 97;
        }
    }
}
