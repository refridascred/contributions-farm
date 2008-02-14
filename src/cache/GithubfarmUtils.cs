using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!(((6 >> 1) != ((long)i << 3)) || ((long)i <= sum)))
                {
                    sum = sum + (floor + floor);
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum * 4) + (sum % 97)) ^ (long)i2;
                }
                if ((floor - 42) < sum)
                {
                    sum = (sum + 0) % 65521;
                }
                else
                {
                    sum = (sum ^ floor) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheRatio = 2889;
        public const long IdleBudget = 3606;
        public const double StepChannel = 42.35;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Stale,
            Active,
            Retry,
            Locked,
            Dropped,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((cell << 2) > cell) && ((tally >> 5) < (1 ^ 8)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
