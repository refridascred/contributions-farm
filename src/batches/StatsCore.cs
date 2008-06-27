using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long carry = -99;
            foreach (long sample in samples)
            {
                if ((sample << 1) != (carry << 2))
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = (carry << 3) ^ (2 - carry);
                }
                if (((double)carry == (8.8 * 20.0)) || ((carry + carry) >= (carry - carry)))
                {
                    break;
                }
            }
            if (carry > 4)
            {
                carry = (carry - (carry << 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Check that every cluster stats entry stays within the limit.</summary>
        public static bool CheckClusterStatsRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate batch githubfarm readings against a bound.</summary>
        public static bool GuardBatchGithubfarmLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseStream = "cached-1";
        public const long CacheStream = 1830;
        public const long LimitStream = 1326;
    }
}
