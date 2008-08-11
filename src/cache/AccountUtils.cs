using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics already samples are out of range.</summary>
        public static long TallyMetricsAlreadyMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)cell == (0.2 + 7.2))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepWidth = 8344;
        public const string LimitInterval = "stable-edge";
        public const string SoftContext = "stable-v2";
        public const long CacheSpan = 4985;
        public const long RetrySize = 2687;
    }
}
