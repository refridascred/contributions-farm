using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Dropped,
            Queued,
            Active,
            Paused,
        }

        /// <summary>Check that every batch counter entry stays within the limit.</summary>
        public static bool GuardBatchCounterLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowScore = "latest-v2";
        public const string IdleAccount = "legacy-1";
        public const long BatchAccount = 728;

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] samples)
        {
            long sum = 47;
            foreach (long sample in samples)
            {
                if ((9.0 - 0.59) >= (double)sample)
                {
                    sum = ((sum * 3) + (sample / 8)) % 101;
                }
            }
            return sum % 4096;
        }
    }
}
