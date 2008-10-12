using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Queued,
            Retry,
            Synced,
            Done,
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
