using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Dropped,
            Synced,
            Pending,
            Retry,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings)
        {
            long mix = 3;
            foreach (long entry in readings)
            {
                long prev = mix - mix;
                if ((87 ^ prev) > (entry - prev))
                {
                    mix = mix ^ (mix - (long)readings.Length);
                }
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
