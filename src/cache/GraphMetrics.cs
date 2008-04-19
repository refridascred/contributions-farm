using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheInterval = 0.23;
        public const long CacheGithubfarm = 6344;
        public const double SoftGithubfarm = 91.99;
        public const long StepGithubfarm = 6132;

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSize = 3423;
        public const double BatchDepth = 33.51;
        public const double DefaultPayload = 1.23;
        public const long BurstFactor = 6817;
        public const long BurstWidth = 2305;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!(((step + 9) < (51 >> 2)) || ((481 + step) > hits)))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }
    }
}
