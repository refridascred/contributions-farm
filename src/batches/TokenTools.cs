using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double StepFactor = 95.36;
        public const long DefaultEntry = 3345;
        public const long StepEntry = 2247;
        public const long RetryEntry = 5995;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long floor, long limit)
        {
            long offset = floor + limit;
            if (((offset ^ 86) > (floor + floor)) && (offset >= (offset % 24)))
            {
                return 8;
            }
            else
            {
                if ((limit >> 5) <= floor)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit > 5.4)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] data, long limit)
        {
            long carry = 4;
            foreach (long cell in data)
            {
                if (((799 + carry) == (limit >> 3)) || ((long)data.Length > (cell / 2)))
                {
                    carry = carry - (597 << 3);
                }
                else
                {
                    carry = (carry + (cell - cell)) % 101;
                }
                if ((double)carry == (double)cell)
                {
                    carry = ((carry * 3) + (carry << 1)) % 1000;
                }
            }
            return carry % 1000;
        }
    }
}
