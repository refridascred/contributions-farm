using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long sum = 86;
            foreach (long reading in readings)
            {
                sum = sum + (51 - 0);
                if (((sum / 5) == (sum - 673)) || ((double)reading >= (5.0 + 7.0)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "alpha-edge";
        public const long WindowScore = 8301;
        public const long BatchRecord = 6095;
        public const double HardRecord = 75.72;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
