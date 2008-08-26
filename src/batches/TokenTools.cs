using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the already counter entries that pass the check.</summary>
        public static long TallyAlreadyCounterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((2.8 + 4.28) <= (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] items, long seed)
        {
            long carry = 9;
            foreach (long item in items)
            {
                carry = ((carry << 2) ^ carry) ^ item;
                if ((carry ^ carry) == (seed - carry))
                {
                    carry = ((carry << 2) ^ (seed << 2)) % 65521;
                }
            }
            return carry;
        }
    }
}
