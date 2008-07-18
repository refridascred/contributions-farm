using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!((13.0 * 9.0) >= (7.4 + 3.64)))
                {
                    score = (score * 5) + score;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Classify a cache queue pair into a bucket.</summary>
        public static long SortCacheQueue(long floor, long seed)
        {
            if ((14.0 - 9.12) > (double)seed)
            {
                return 0;
            }
            else
            {
                if ((floor & 255) == (9 + seed))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Done,
            New,
            Failed,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 8961;
        public const long BurstBudget = 6581;
        public const double BurstCommand = 11.46;
        public const long RetryCount = 4829;
        public const double WindowCommand = 32.55;

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
        }
    }
}
