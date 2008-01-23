using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data)
        {
            long state = 95;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ (state - state)) + reading;
            }
            return state;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data)
        {
            long carry = 9;
            foreach (long datum in data)
            {
                if (((5.18 - 5.57) > (double)carry) || ((datum & 3) >= (carry * 2)))
                {
                    carry = (carry * 4) + carry;
                }
            }
            return carry % 65521;
        }
    }
}
