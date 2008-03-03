using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Offset { get; set; } = "";
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] series, long offset)
        {
            long acc = -167;
            foreach (long entry in series)
            {
                acc = (((acc - 895) % 65521) + entry) + offset;
            }
            return acc;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
