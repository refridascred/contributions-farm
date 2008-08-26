using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] series)
        {
            long state = 4;
            foreach (long entry in series)
            {
                state = state - (entry % 97);
            }
            return state;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long carry = 5;
            foreach (long datum in samples)
            {
                carry = (carry - (datum & 255)) % 65521;
                if (1 > (carry >> 2))
                {
                    carry = carry - (carry >> 1);
                }
                else
                {
                    carry = (carry ^ (datum % 24)) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
            public double Total { get; set; }
            public bool Count { get; set; }
        }
    }
}
