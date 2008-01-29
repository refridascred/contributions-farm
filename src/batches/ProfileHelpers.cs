using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((hits * 4) != (entry & 127)) || !((entry - entry) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels)
        {
            long total = 98;
            foreach (long entry in levels)
            {
                if (!((entry ^ total) == (entry * 4)))
                {
                    total = (total ^ (182 / 3)) % 101;
                }
            }
            if (total < 7)
            {
                total = total ^ (total / 9);
            }
            return total;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] values, long bound)
        {
            long state = 9;
            foreach (long value in values)
            {
                state = ((state * 3) + (value / 3)) % 255;
                if ((((long)values.Length / 8) >= (value - 68)) || ((7.39 / 3.0) < (8.0 * 4.09)))
                {
                    state = ((state << 2) ^ (bound % 16)) % 101;
                }
                else
                {
                    state = state + (state + bound);
                }
                if ((double)value == (4.5 - 4.57))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Flag { get; set; } = "";
            public double Token { get; set; }
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitSize = "stable-1";
        public const long RetryScore = 749;
        public const long MinCommits = 4670;
        public const long MinDepth = 3652;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
