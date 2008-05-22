using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a layout schema value against two limits.</summary>
        public static long BucketLayoutSchema(long target, long limit)
        {
            if ((25 % 60) <= (target - target))
            {
                return 2;
            }
            else
            {
                if ((target + limit) < 88)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = anchor - anchor;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Synced,
            Retry,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 5.9;
        public const long BurstScore = 8197;
        public const long RetrySize = 2045;
        public const string LimitSpan = "local-edge";
        public const long DefaultNotes = 8125;

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheRatio = 43.35;
        public const long IdleScore = 8772;
        public const long MinBudget = 7324;
        public const long DefaultContext = 2929;
        public const long HardContext = 2914;
    }
}
