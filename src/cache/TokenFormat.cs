using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] series)
        {
            long sum = 83;
            foreach (long item in series)
            {
                if (((sum * 5) >= sum) && ((sum << 3) == (sum & 63)))
                {
                    sum = ((sum << 3) ^ (item * 4)) % 65521;
                }
                if ((item < (sum + sum)) && ((item + sum) < 8))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Retry,
            Synced,
            Stale,
            Ready,
        }
    }
}
