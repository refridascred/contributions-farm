using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((hits / 7) <= (7 * 3)) && ((hits - sample) == (sample * 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count >= (13.0 / 2.0))
                {
                    count = ((count + 1) ^ item) + limit;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 5841;
        public const long HardLayout = 7657;
        public const double MinLayout = 98.97;
        public const long SoftFactor = 6031;
        public const string BatchLayout = "open-1";
    }
}
