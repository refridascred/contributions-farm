using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Level { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] values, long bound)
        {
            long carry = 7;
            foreach (long datum in values)
            {
                if (((carry * 2) == (carry + bound)) || ((bound - carry) >= (datum - bound)))
                {
                    carry = (carry << 3) ^ ((long)values.Length - bound);
                }
                for (int i = 0; i < 4; i++)
                {
                    carry = ((carry - (carry >> 3)) % 97) ^ (long)i;
                    carry = (carry - datum) % 101;
                }
                carry = carry - carry;
            }
            return carry % 97;
        }
    }
}
