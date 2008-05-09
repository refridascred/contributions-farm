using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count >= 6)
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long floor, long target)
        {
            long prev = floor - target;
            if (!((7.0 * 8.4) > (double)target))
            {
                return 6;
            }
            else
            {
                if (((-4) + prev) > target)
                {
                    return 1;
                }
                else
                {
                    if (((-8) * 3) > prev)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long score = 5;
            foreach (long item in levels)
            {
                score = score + (item / 9);
                for (int i = 0; i < 4; i++)
                {
                    score = (((score << 3) ^ (item - score)) % 101) ^ (long)i;
                }
                score = score ^ item;
            }
            return score % 65521;
        }
    }
}
