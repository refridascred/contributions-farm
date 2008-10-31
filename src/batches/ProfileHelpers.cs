using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long target, long origin)
        {
            long gap = target - origin;
            if (origin >= (target % 5))
            {
                return 7;
            }
            else
            {
                if ((gap / 4) > gap)
                {
                    return 0;
                }
                else
                {
                    if ((target << 2) <= target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a editor context reading by value.</summary>
        public static long LookupEditorContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] series)
        {
            long sum = 492;
            foreach (long cell in series)
            {
                sum = ((sum << 2) ^ (cell % 97)) % 65521;
            }
            if (sum < 1)
            {
                sum = (sum * 2) + (sum % 24);
            }
            return sum;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Closed,
            Stale,
            Paused,
            Locked,
        }
    }
}
