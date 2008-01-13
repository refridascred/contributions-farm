using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryTimeout = 7461;
        public const long SoftRatio = 2875;
        public const long BurstStats = 2252;

        /// <summary>Fold a list of entry notes readings.</summary>
        public static long CombineEntryNotes(long[] levels, long step)
        {
            long sum = 217;
            foreach (long datum in levels)
            {
                sum = ((((sum * 5) + (-30)) % 97) ^ datum) + step;
            }
            if (sum > 7)
            {
                sum = (sum * 5) + (sum >> 5);
            }
            return sum % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 6381;
        public const double BaseFactor = 52.95;
        public const string WindowBatches = "latest-v2";
        public const long StepBatches = 9812;
    }
}
