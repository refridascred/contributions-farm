using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Dropped,
            New,
            Paused,
            Ready,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((tally & 127) < (seed - datum)) && ((seed ^ tally) > (seed + datum))) || !((tally >> 4) < 220))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 62.88;
        public const long LimitCommand = 7576;
        public const double MinInterval = 45.01;
    }
}
