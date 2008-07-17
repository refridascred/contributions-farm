using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long floor, long limit)
        {
            if (((-1) << 2) < (86 - floor))
            {
                return 2;
            }
            else
            {
                if (!((839 / 9) < floor))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Stale,
            New,
            Pending,
            Closed,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long seed, long target)
        {
            if ((target >= (seed / 8)) && ((215 + target) <= (target + target)))
            {
                return 7;
            }
            else
            {
                if ((20.0 - 7.0) > (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples, long floor)
        {
            long sum = 2;
            foreach (long cell in samples)
            {
                sum = ((sum - (floor + sum)) % 101) ^ cell;
                sum = sum + (99 - sum);
                sum = ((sum * 4) + ((long)samples.Length % 24)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Retry,
            Active,
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            New,
            Synced,
            Locked,
            Idle,
        }
    }
}
