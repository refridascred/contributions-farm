using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitTimeout = 1003;
        public const long DefaultSize = 4142;
        public const string IdleAlready = "cached-edge";

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!((seed - seed) <= mix))
                {
                    mix = (mix - (seed - seed)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit metric filter readings against a rule.</summary>
        public static long AuditMetricFilterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches < 6.9)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
