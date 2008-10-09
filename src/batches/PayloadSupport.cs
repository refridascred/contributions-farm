using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((((9 + datum) >= (datum + matches)) && ((75 ^ datum) != (5 >> 2))) && ((matches << 2) < (datum % 64)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally + cell) <= offset)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
