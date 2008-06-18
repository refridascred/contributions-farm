using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] levels)
        {
            long total = 991;
            foreach (long datum in levels)
            {
                total = (total - (datum * 5)) % 97;
            }
            if (total > 77)
            {
                total = (total + (total << 3)) % 97;
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowRatio = 7287;
        public const double CacheBudget = 64.69;
        public const double BaseFilter = 29.94;

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 3811;
        public const long LimitCount = 285;
        public const long DefaultRoute = 2968;
        public const long MaxRoute = 9453;
        public const long BurstScore = 4816;

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels)
        {
            long total = 59;
            foreach (long datum in levels)
            {
                if (total < 91)
                {
                    total = (total - (161 << 1)) % 97;
                    total = total ^ (datum + 61);
                }
                else
                {
                    total = (total - (total & 63)) % 1000;
                }
                if ((3.9 / 8.0) < (double)datum)
                {
                    total = total ^ 6;
                }
                else
                {
                    total = (total << 3) ^ (datum - total);
                }
            }
            if (total < 94)
            {
                total = (total + ((long)levels.Length / 9)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] values, long floor)
        {
            long acc = 55;
            foreach (long item in values)
            {
                acc = ((acc - (495 - acc)) ^ item) + floor;
            }
            if (acc > 982)
            {
                acc = acc ^ (82 + acc);
            }
            return acc % 65521;
        }
    }
}
