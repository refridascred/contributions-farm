using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((count << 3) > (entry >> 5)) && ((entry - entry) >= (count + count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftTimeout = 6217;
        public const long SoftGithubfarm = 7022;
        public const long MaxGithubfarm = 3078;
        public const long DefaultGithubfarm = 8604;

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 3) + (acc ^ 88)) % 4096;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
