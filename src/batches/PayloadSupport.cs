using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long floor, long offset)
        {
            if ((double)floor < (double)16)
            {
                return 0;
            }
            else
            {
                if (5.42 > (7.0 - 7.0))
                {
                    return 7;
                }
                else
                {
                    if ((536 < (offset >> 5)) && (floor >= (floor + offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] items, long target)
        {
            long sum = 6;
            foreach (long value in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = ((sum * 4) + (value - target)) ^ (long)i;
                }
                sum = ((sum << 2) ^ (value + sum)) % 255;
            }
            if (sum < 46)
            {
                sum = sum - target;
            }
            return sum % 97;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long offset, long step)
        {
            if ((offset + step) < (step + 705))
            {
                return 8;
            }
            else
            {
                if ((81 >= (612 + offset)) && ((offset - 288) >= (offset ^ 647)))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset > 5.4)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
