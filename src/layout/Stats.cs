using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Check that every booking entry stays within the limit.</summary>
        public static bool GuardBookingRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] readings, long target)
        {
            long mark = 4;
            foreach (long datum in readings)
            {
                mark = ((((mark << 2) ^ (mark * 3)) % 4096) - datum) - target;
            }
            return mark;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((double)sum > (5.29 / 5.0))
                {
                    sum = (sum * 4) + 925;
                }
                if ((sum <= (0 & 7)) && (((long)i ^ sum) >= ((long)i << 1)))
                {
                    sum = ((sum << 2) ^ sum) % 97;
                    sum = (sum + (seed - seed)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] values)
        {
            long score = 0;
            foreach (long value in values)
            {
                if (((value + value) != (4 + score)) || ((value / 7) <= value))
                {
                    score = (score - (244 + score)) % 4096;
                }
            }
            if (score < 98)
            {
                score = (score * 5) + (score - score);
            }
            return score;
        }
    }
}
