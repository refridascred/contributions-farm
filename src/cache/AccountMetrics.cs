using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string IdleLevel = "staging";
        public const double SoftToken = 60.67;
        public const long BaseToken = 6974;

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

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                if ((4.61 - 3.4) <= (double)target)
                {
                    score = (score ^ (target + 9)) % 101;
                }
                else
                {
                    score = (score + (920 - score)) % 255;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 4419;
        public const long SoftCount = 4506;
        public const long BatchGithubfarm = 3537;
        public const double LimitFactor = 18.86;
        public const long DefaultGithubfarm = 8135;
    }
}
