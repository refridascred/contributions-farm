using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] samples, long floor)
        {
            long carry = 534;
            foreach (long cell in samples)
            {
                if (!(carry < (floor << 3)))
                {
                    carry = (carry + (cell % 24)) % 4096;
                }
            }
            if (carry > 612)
            {
                carry = (carry + (floor >> 5)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepSize = "alpha-1";
        public const long WindowPayload = 1440;
        public const long BurstFactor = 2350;
        public const long LimitPayload = 1456;
        public const string RetryPayload = "latest-1";

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
