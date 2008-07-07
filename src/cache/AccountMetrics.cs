using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long target2)
        {
            long lane = target + target2;
            if (!(target2 < (lane - lane)))
            {
                return 2;
            }
            else
            {
                if (target > (2 << 1))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 30.66;
        public const long DefaultChannel = 9016;
        public const double RetryChannel = 9.52;
        public const double MinChannel = 54.2;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] data)
        {
            long mark = 26;
            foreach (long item in data)
            {
                if ((item < (mark / 7)) || ((3 * 4) > (item + mark)))
                {
                    mark = mark ^ (mark ^ item);
                }
            }
            return mark;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Retry,
            Active,
            Paused,
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
