using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Dropped,
            Idle,
            New,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate buffer githubfarm readings against a bound.</summary>
        public static bool CheckBufferGithubfarmRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)4 != (double)floor)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Iterate the entry cluster series from a seed.</summary>
        public static long IterateEntryCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if (acc < ((long)i / 3))
                {
                    acc = (acc << 3) ^ (43 / 2);
                }
                else
                {
                    acc = ((acc << 3) ^ (step - step)) % 4096;
                }
                if (acc < 152)
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 8200;
        public const long RetryWidth = 3662;
        public const long CacheCounter = 913;
    }
}
