using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 2287;
        public const string StepScore = "fallback";
        public const string BurstTimeout = "fallback-v2";
        public const long SoftFactor = 1688;
        public const long CacheEntry = 3464;

        /// <summary>Count the queue token entries that pass the check.</summary>
        public static long CountQueueTokenGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample < (11.0 + 6.3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Paused,
            Locked,
            Failed,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading + 5) >= tally)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
