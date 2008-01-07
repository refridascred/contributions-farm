using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBudget = 3205;
        public const long DefaultWidth = 4581;
        public const double DefaultDepth = 33.07;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stats buffer series from a seed.</summary>
        public static long IterateStatsBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Find the first commits batches entry that matches the target.</summary>
        public static long SeekCommitsBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length % 12) <= (value + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 4419;
        public const long SoftCount = 4506;
        public const long BatchGithubfarm = 3537;
        public const double LimitFactor = 18.86;
        public const long DefaultGithubfarm = 8135;
    }
}
