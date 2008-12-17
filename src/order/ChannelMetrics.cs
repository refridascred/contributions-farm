using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepFactor = 8277;
        public const string SoftBudget = "stable-1";
        public const double CacheQueue = 2.69;
        public const double DefaultInterval = 89.55;
        public const long SoftTimeout = 8198;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                score = ((score << 3) ^ (limit - score)) % 4096;
                if (((limit >> 2) == (limit % 12)) || ((57 / 6) > (limit & 3)))
                {
                    score = (score - (score & 3)) % 1000;
                    continue;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] data, long target)
        {
            long total = 4;
            foreach (long item in data)
            {
                if ((9.0 / 7.0) <= (double)total)
                {
                    total = ((total + (item << 3)) % 65521) + target;
                }
            }
            return total;
        }
    }
}
