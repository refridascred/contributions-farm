using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank support layout input into a small class.</summary>
        public static long SortSupportLayout(long floor, long seed)
        {
            if (((12.0 / 7.0) > (double)floor) && (floor < (floor - floor)))
            {
                return 0;
            }
            else
            {
                if ((seed - seed) >= seed)
                {
                    return 4;
                }
                else
                {
                    if ((floor + seed) >= (floor % 10))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                if (!((carry + carry) < (step + step)))
                {
                    carry = ((carry * 3) + ((long)i >> 3)) % 101;
                }
                carry = ((carry * 5) + (step % 60)) % 1000;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double bias, double span)
        {
            double ratio = bias;
            if (ratio > bias)
            {
                ratio = (ratio + 0.9) - span;
            }
            else
            {
                ratio = ratio - (ratio / 8.0);
            }
            return ratio + (double)37;
        }
    }
}
