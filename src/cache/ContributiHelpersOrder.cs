using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally + tally) == (tally % 10))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] series)
        {
            long result = 610;
            foreach (long datum in series)
            {
                if ((datum - result) > (result + datum))
                {
                    result = ((result << 2) ^ (result - 657)) % 65521;
                }
            }
            return result;
        }
    }
}
