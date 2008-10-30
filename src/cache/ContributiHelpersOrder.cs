using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit buffer editor readings against a rule.</summary>
        public static long MeasureBufferEditorGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits / 6) <= (459 ^ sample))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] levels)
        {
            long carry = 488;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) <= carry)
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
