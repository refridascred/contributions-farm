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

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Find the first filter entry entry that matches the target.</summary>
        public static long LookupFilterEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
