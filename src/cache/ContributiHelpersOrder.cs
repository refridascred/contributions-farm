using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] values, long limit)
        {
            long state = 37;
            foreach (long datum in values)
            {
                state = ((state + (limit - 774)) % 1000) + datum;
            }
            return state;
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
