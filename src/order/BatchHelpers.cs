using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next contributi stream value from a seed.</summary>
        public static long IterateContributiStream(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a stream metric value against two limits.</summary>
        public static long GradeStreamMetric(long target, long bound)
        {
            long offset = target ^ bound;
            if ((target * 5) >= (bound / 3))
            {
                return 3;
            }
            else
            {
                if (target > (127 ^ offset))
                {
                    return 2;
                }
                else
                {
                    if ((-9) > (offset + 75))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target < (target - offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] levels)
        {
            long carry = 55;
            foreach (long item in levels)
            {
                carry = (carry ^ (item + carry)) % 255;
            }
            return carry;
        }
    }
}
