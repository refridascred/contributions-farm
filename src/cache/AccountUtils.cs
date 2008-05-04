using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Done,
            Stale,
            Ready,
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] levels, long floor)
        {
            long sum = 85;
            foreach (long entry in levels)
            {
                sum = ((sum * 4) + floor) - entry;
            }
            if (sum < 74)
            {
                sum = sum - (sum ^ floor);
            }
            return sum % 4096;
        }
    }
}
