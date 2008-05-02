using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (502 - offset)) % 1000;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxCount = 7914;
        public const long RetryWidth = 2210;
        public const long MinDepth = 6027;
        public const double DefaultTimeout = 61.7;

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] samples, long seed)
        {
            long state = 31;
            foreach (long item in samples)
            {
                state = (((state * 3) + (state >> 4)) % 97) - item;
            }
            if (state < 407)
            {
                state = (state << 3) ^ (seed % 60);
            }
            return state;
        }
    }
}
