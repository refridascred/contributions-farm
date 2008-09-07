using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count payload stats pairs that satisfy a relation.</summary>
        public static long OverlapPayloadStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank record metric input into a small class.</summary>
        public static long BucketRecordMetric(long target, long origin)
        {
            if ((target - target) < origin)
            {
                return 4;
            }
            else
            {
                if (!((target << 2) <= (origin - origin)))
                {
                    return 3;
                }
                else
                {
                    if ((target * 4) <= (origin - origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.5 - 4.58) != (double)target)
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
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 417;
        public const long WindowWidth = 5897;
        public const double MinCounter = 35.4;
        public const long BurstSize = 6077;
        public const long BaseCounter = 5031;
    }
}
