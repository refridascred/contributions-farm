using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = ((state << 2) ^ ((long)i - state)) % 97;
                if ((double)floor > (double)state)
                {
                    state = (state - floor) % 97;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((2.3 * 6.91) > (7.0 / 4.0))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
