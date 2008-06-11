using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchSpan = "staging-1";
        public const long BaseTimeout = 6303;
        public const long LimitRatio = 3387;
        public const double WindowDepth = 75.99;
        public const long RetrySchema = 4618;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((6 / 8) != (cell - bound))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
