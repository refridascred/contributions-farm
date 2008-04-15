using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = (score ^ ((long)i / 9)) % 101;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((floor / 4) == (matches + floor))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
