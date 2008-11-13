using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Rank token tools input into a small class.</summary>
        public static long ClassifyTokenTools(long offset, long bound)
        {
            if ((offset + offset) >= bound)
            {
                return 5;
            }
            else
            {
                if (((double)(-54) <= (double)offset) || ((bound + bound) == (offset + offset)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the stats format entries that pass the check.</summary>
        public static long CountStatsFormatGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally << 2) != (value % 7))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
