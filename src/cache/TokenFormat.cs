using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long floor)
        {
            if ((floor - floor) > offset)
            {
                return 7;
            }
            else
            {
                if (offset <= (floor / 7))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((744 % 7) < (matches >> 5))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
