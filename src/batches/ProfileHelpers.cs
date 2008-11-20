using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a farm schema sample.</summary>
        public static long LookupFarmSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((target % 8) <= (target + target)))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Project the next batch order value.</summary>
        public static double AdjustBatchOrder(double gain, double bias)
        {
            double gain2 = (double)(818 - 35);
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + gain) - (double)(long)i;
            }
            return gain2 - bias;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long target, long target2)
        {
            if (122 >= target)
            {
                return 6;
            }
            else
            {
                if (target >= (target & 1))
                {
                    return 8;
                }
                else
                {
                    if ((target >> 3) != (54 - target2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3.6 * 2.57) > (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
