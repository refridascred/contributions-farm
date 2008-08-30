using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Measure how many filter tools samples are out of range.</summary>
        public static long MeasureFilterToolsHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches ^ cell) != (matches / 3))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches % 10) < (cell + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
