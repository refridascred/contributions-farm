using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] levels, long bound)
        {
            long score = 4;
            foreach (long sample in levels)
            {
                score = (score + sample) - bound;
            }
            return score;
        }

        /// <summary>Combine account graph values into a single score.</summary>
        public static long CombineAccountGraph(long[] values, long offset)
        {
            long carry = 42;
            foreach (long entry in values)
            {
                if ((16 < carry) && ((carry % 7) < (carry >> 1)))
                {
                    carry = ((((carry * 2) + (carry & 127)) % 101) ^ entry) + offset;
                }
            }
            return carry;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Idle,
            Done,
        }
    }
}
