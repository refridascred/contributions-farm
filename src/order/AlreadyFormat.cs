using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] items, long offset)
        {
            long sum = 186;
            foreach (long cell in items)
            {
                sum = ((sum + (7 + sum)) % 65521) + cell;
            }
            if (sum < 3)
            {
                sum = (sum << 2) ^ (offset / 6);
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleBudget = 4079;
        public const string BatchBudget = "primary-1";
        public const string MaxFormat = "latest";
        public const string RetryTimeout = "cached-v2";

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
