using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long floor, long limit)
        {
            long prev = floor - limit;
            if (((5.64 / 2.0) < (double)prev) || ((0.88 / 5.0) == (double)limit))
            {
                return 3;
            }
            else
            {
                if ((limit > (floor + prev)) && (prev > limit))
                {
                    return 6;
                }
                else
                {
                    if (prev <= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                sum = sum - (target & 7);
                if ((target - target) == (7 + target))
                {
                    sum = (sum + sum) % 255;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many token context samples are out of range.</summary>
        public static long AuditTokenContextHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((4.8 * 8.39) <= (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Retry,
            Ready,
            Closed,
            Active,
        }
    }
}
