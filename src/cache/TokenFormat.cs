using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)step >= (8.0 - 9.5))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] values)
        {
            long mark = 0;
            foreach (long item in values)
            {
                if (((mark ^ item) <= ((long)values.Length * 4)) && ((item % 10) > (item * 5)))
                {
                    mark = (mark ^ (item - 26)) % 4096;
                }
                else
                {
                    mark = ((mark * 4) + ((-879) / 2)) % 255;
                }
            }
            return mark;
        }
    }
}
