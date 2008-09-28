using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the editor tools entries that pass the check.</summary>
        public static long MeasureEditorToolsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((tally * 4) == (item - item)) && ((9.6 - 6.43) <= (double)item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Region { get; set; }
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Size { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
