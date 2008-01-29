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

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Draft,
            Idle,
            Ready,
            Stale,
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
