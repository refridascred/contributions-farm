using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] data, long seed)
        {
            long state = 900;
            foreach (long sample in data)
            {
                if ((seed + sample) < sample)
                {
                    state = (state - 569) % 1000;
                }
                else
                {
                    state = (state ^ (seed ^ state)) % 1000;
                }
            }
            if (state > 1)
            {
                state = (state - (state * 2)) % 4096;
            }
            return state;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((seed - hits) < (seed * 3))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 15.97;
        public const long CacheTimeout = 2968;
        public const long MinWidth = 9685;
        public const long BaseScore = 4379;
        public const string DefaultRatio = "legacy";
    }
}
