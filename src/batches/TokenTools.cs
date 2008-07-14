using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!!(tally <= datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Pending,
            New,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public double Mode { get; set; }
        }
    }
}
