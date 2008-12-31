using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the record channel entries that pass the check.</summary>
        public static long CountRecordChannelHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (1.0 <= (double)hits)
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchReport = 75.45;
        public const long BatchWidth = 4321;
        public const long WindowReport = 4242;

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 8938;
        public const string HardFormat = "open-1";
        public const long RetryInterval = 7958;
        public const long MinFormat = 9776;
        public const string IdleCount = "open";
    }
}
