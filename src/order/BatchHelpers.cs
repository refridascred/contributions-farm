using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                if (((target + (long)i) < ((long)i / 4)) || ((4.1 - 3.5) < (double)carry))
                {
                    carry = (carry - (target + (long)i)) % 4096;
                    carry = (carry + (carry * 2)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Audit cache contributi readings against a rule.</summary>
        public static long TallyCacheContributiHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (3.25 < (double)seed)
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }
    }
}
