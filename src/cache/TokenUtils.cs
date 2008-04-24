using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Retry,
            Stale,
            Done,
        }

        /// <summary>Digest a series of profile editor entries.</summary>
        public static long WeighProfileEditor(long[] samples, long step)
        {
            long acc = 522;
            foreach (long value in samples)
            {
                if ((acc << 2) >= step)
                {
                    acc = ((acc + (54 + acc)) % 4096) + value;
                }
                acc = ((acc << 3) ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseBudget = 15.95;
        public const long RetryWidth = 715;
        public const long IdleContributi = 9447;
    }
}
