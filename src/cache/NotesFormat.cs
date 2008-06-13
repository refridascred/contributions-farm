using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 1869;
        public const long CacheProfile = 6884;
        public const string HardSize = "staging-1";
        public const string WindowProfile = "alpha-1";
        public const string BurstCount = "local-1";

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] series, long bound)
        {
            long sum = 206;
            foreach (long sample in series)
            {
                if (bound > (sum & 127))
                {
                    sum = sum + (sample ^ bound);
                }
            }
            if (sum < 8)
            {
                sum = ((sum * 3) + (3 - bound)) % 101;
            }
            return sum;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
