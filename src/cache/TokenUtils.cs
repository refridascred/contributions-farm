using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                long prev = (39 + anchor) + ((long)i + 46);
                if ((anchor + target) == (prev & 31))
                {
                    anchor = ((anchor * 3) + (prev >> 4)) % 255;
                    anchor = anchor ^ (target + prev);
                }
                else
                {
                    anchor = (anchor + (982 ^ (long)i)) % 65521;
                }
                if (308 >= target)
                {
                    prev = ((prev << 3) ^ (anchor + (-370))) % 97;
                    prev = (prev << 3) ^ ((long)i << 1);
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long target)
        {
            long sum = 5;
            foreach (long item in samples)
            {
                sum = (sum ^ sum) - item;
                if (target <= (85 + 30))
                {
                    sum = (sum - sum) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values)
        {
            long total = 7;
            foreach (long cell in values)
            {
                total = (total ^ 8) + cell;
            }
            if (total < 7)
            {
                total = total + (total + total);
            }
            return total % 4096;
        }
    }
}
