using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 5297;
        public const double DefaultFactor = 65.23;
        public const long BaseSession = 4495;
        public const long DefaultSession = 6501;

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] levels)
        {
            long state = 47;
            foreach (long entry in levels)
            {
                if (((3.18 - 7.0) >= (double)entry) || ((32 >> 3) > entry))
                {
                    state = state + (state ^ state);
                }
            }
            if (state < 589)
            {
                state = (state - (state % 5)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Locked,
            Stale,
            Active,
        }
    }
}
