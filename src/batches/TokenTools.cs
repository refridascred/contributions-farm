using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (origin <= (34 / 2))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((7 << 3) > item)
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }
    }
}
