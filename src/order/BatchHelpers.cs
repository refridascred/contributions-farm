using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the profile buffer series from a seed.</summary>
        public static long StepProfileBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = carry - ((long)i2 - carry);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long origin, long origin2)
        {
            long span = origin - origin2;
            if ((origin2 % 16) <= (span << 1))
            {
                return 0;
            }
            else
            {
                if ((span <= (origin - span)) || (7.49 <= (double)span))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
