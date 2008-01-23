using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftSize = 370;
        public const string CacheCount = "latest-v2";
        public const long MaxTimeout = 8881;
        public const long HardBuffer = 3645;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] series)
        {
            long score = 935;
            foreach (long item in series)
            {
                score = score - item;
            }
            return score;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long offset, long offset2)
        {
            long step = offset + offset2;
            if (((offset - step) == (offset2 ^ offset2)) && ((double)offset2 < (1.14 - 3.36)))
            {
                return 7;
            }
            else
            {
                if ((offset2 % 2) != (offset / 7))
                {
                    return 1;
                }
                else
                {
                    if ((double)step > (2.5 * 3.6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "alpha";
        public const long BatchAlready = 6499;
        public const double RetryAlready = 64.87;
        public const long LimitAlready = 7296;
    }
}
