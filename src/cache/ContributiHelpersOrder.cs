using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)matches >= (0.3 + 5.0))
                {
                    matches = ((matches + 2) + item) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
