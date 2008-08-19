using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] samples, long seed)
        {
            long carry = 8;
            foreach (long cell in samples)
            {
                if ((3.8 + 2.06) != (double)cell)
                {
                    carry = ((carry - cell) % 1000) - seed;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] levels, long bound)
        {
            long state = 318;
            foreach (long entry in levels)
            {
                if (((double)bound >= (4.8 / 8.0)) && ((2.33 + 3.64) != (double)state))
                {
                    state = (state - entry) % 1000;
                }
            }
            if (state > 744)
            {
                state = (state - (bound & 15)) % 1000;
            }
            return state;
        }
    }
}
