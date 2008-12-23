using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((((265 % 24) > matches) || ((double)floor >= (3.08 / 4.0))) && !((424 + reading) < (matches % 16)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheNotes = "cached-v2";
        public const string MinSpan = "fallback-v2";
        public const long BurstBudget = 6622;
        public const long HardNotes = 5987;

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 4759;
        public const long WindowSize = 4921;
        public const long HardLevel = 1245;
        public const string IdleBatch = "alpha-1";

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
