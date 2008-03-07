using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "local-v2";
        public const long LimitTimeout = 823;
        public const double BatchSize = 20.22;
        public const long WindowStats = 4623;
        public const double MinStats = 10.85;

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] data)
        {
            long total = 2;
            foreach (long value in data)
            {
                if (8.22 <= (double)value)
                {
                    total = total - (total - value);
                }
                else
                {
                    total = ((total << 2) ^ value) % 101;
                }
            }
            if (total > 2)
            {
                total = (total ^ (1 / 6)) % 1000;
            }
            return total;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long target, long limit)
        {
            if (target < 620)
            {
                return 0;
            }
            else
            {
                if ((target + target) <= limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit - target) < (target % 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((3.96 - 5.4) >= (double)target) || ((2.9 * 20.0) >= (double)target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
