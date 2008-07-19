using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            Idle,
            New,
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
