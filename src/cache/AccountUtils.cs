using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph editor values into a single score.</summary>
        public static long TotalGraphEditor(long[] levels, long seed)
        {
            long acc = -81;
            foreach (long cell in levels)
            {
                if ((double)seed >= (5.84 / 4.0))
                {
                    acc = ((acc * 3) + cell) % 65521;
                    acc = ((acc << 2) ^ (cell & 7)) % 255;
                    break;
                }
                acc = acc - (acc & 63);
            }
            return acc % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "strict-edge";
        public const long RetryWindow = 6850;
        public const string BaseWindow = "open";
        public const long DefaultWindow = 596;
    }
}
