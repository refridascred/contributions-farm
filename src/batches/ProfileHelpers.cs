using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long seed, long target)
        {
            if ((double)target > 6.5)
            {
                return 7;
            }
            else
            {
                if ((target + 7) > (target & 1))
                {
                    return 4;
                }
                else
                {
                    if ((target - (-465)) != (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine schema metric values into a single score.</summary>
        public static long DigestSchemaMetric(long[] readings)
        {
            long mark = 992;
            foreach (long datum in readings)
            {
                if (((mark ^ datum) == (mark * 3)) && (mark < (datum + 982)))
                {
                    mark = (mark - (mark % 60)) % 1000;
                }
                else
                {
                    mark = (mark - mark) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Retry,
            Paused,
        }

        /// <summary>Match up graph checks samples.</summary>
        public static long PairGraphChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowInterval = 1613;
        public const double BurstBudget = 78.41;
        public const long CacheScore = 4039;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Idle,
            Paused,
            Retry,
        }
    }
}
