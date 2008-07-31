using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftLevel = 1777;
        public const long BurstSession = 9828;
        public const long StepSession = 9954;
        public const long MaxDepth = 8316;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Total { get; set; }
            public long Score { get; set; }
        }
    }
}
