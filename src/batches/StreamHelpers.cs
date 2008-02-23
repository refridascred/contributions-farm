using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double bias, double bias2)
        {
            double mean = bias2;
            return mean + bias;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item > (seed - item)) && (item < (long)items.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of buffer window readings.</summary>
        public static long OverlapBufferWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long target, long origin)
        {
            if ((825 >> 3) == (target & 63))
            {
                return 5;
            }
            else
            {
                if ((3.82 * 18.0) >= (double)target)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseWidth = 2992;
        public const string BurstCommits = "standard";
        public const double StepCommits = 40.31;
        public const long BaseCommits = 9288;
    }
}
