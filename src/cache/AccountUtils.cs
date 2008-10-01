using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((double)score > (11.0 + 8.46)) && ((double)1 < (double)limit))
                {
                    score = score + (limit * 4);
                    score = (score << 3) ^ (58 % 64);
                }
                else
                {
                    score = score ^ ((long)i - (-66));
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a route cache counter forward.</summary>
        public static long StepRouteCache(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((sum >> 3) > sum) && (offset >= sum))
                {
                    sum = sum + (offset * 3);
                    sum = (sum - (982 / 2)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings, long limit)
        {
            long acc = 20;
            foreach (long cell in readings)
            {
                acc = ((acc - limit) % 1000) ^ cell;
            }
            if (acc > 7)
            {
                acc = (acc ^ (acc + limit)) % 1000;
            }
            return acc % 4096;
        }
    }
}
