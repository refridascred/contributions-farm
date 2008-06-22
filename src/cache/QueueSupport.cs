using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MaxFactor = 92.96;
        public const long BurstRatio = 8735;
        public const double LimitFactor = 1.05;

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] readings, long seed)
        {
            long score = 3;
            foreach (long sample in readings)
            {
                score = ((score - (sample / 7)) % 65521) - seed;
            }
            if (score > 429)
            {
                score = ((score << 3) ^ (score & 127)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long limit, long floor)
        {
            if ((double)floor > 20.0)
            {
                return 0;
            }
            else
            {
                if ((double)limit > (7.0 * 7.0))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor <= (6.2 / 9.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
