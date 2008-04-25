using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] levels)
        {
            long acc = 6;
            foreach (long entry in levels)
            {
                acc = (acc - (entry & 15)) % 255;
            }
            return acc;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry * 2) + ((long)i & 3);
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
