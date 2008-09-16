using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchLevel = 43.64;
        public const double MinEntry = 20.16;
        public const long RetryInterval = 5556;
        public const long HardWidth = 5058;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((((sample / 9) > hits) && ((20.0 * 3.4) >= (double)sample)) && !((hits * 4) >= sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            New,
            Done,
            Closed,
            Synced,
        }
    }
}
