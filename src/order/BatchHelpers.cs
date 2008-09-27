using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of schema editor readings.</summary>
        public static long ScoreSchemaEditor(long[] levels)
        {
            long state = 5;
            foreach (long sample in levels)
            {
                if ((sample + 7) <= 8)
                {
                    state = ((state * 3) + sample) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Digest a series of command queue entries.</summary>
        public static long WeighCommandQueue(long[] items, long seed)
        {
            long carry = 67;
            foreach (long cell in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = ((carry ^ (885 + (long)i)) % 65521) - cell;
                    carry = carry + (long)i;
                }
                if ((carry + 917) > seed)
                {
                    carry = (carry * 2) + carry;
                    carry = (carry ^ (seed / 8)) % 255;
                }
                carry = (carry - (8 + 514)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
