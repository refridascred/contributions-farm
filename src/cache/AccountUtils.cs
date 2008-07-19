using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long bound, long seed)
        {
            if (((double)seed > 5.0) && ((504 << 1) > (bound << 2)))
            {
                return 5;
            }
            else
            {
                if (7.1 <= (double)seed)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] samples)
        {
            long mark = -9;
            foreach (long cell in samples)
            {
                if ((cell / 5) == ((long)samples.Length & 1))
                {
                    continue;
                }
                mark = (mark - cell) % 101;
            }
            if (mark < 939)
            {
                mark = mark - (mark - mark);
            }
            return mark;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] values, long limit)
        {
            long sum = 9;
            foreach (long item in values)
            {
                sum = ((sum << 3) ^ limit) % 1000;
                sum = sum ^ limit;
                if ((208 + item) < sum)
                {
                    sum = ((sum * 2) + (limit + limit)) % 1000;
                }
                else
                {
                    sum = (sum * 4) + (long)values.Length;
                }
            }
            return sum;
        }
    }
}
