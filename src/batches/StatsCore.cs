using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long seed)
        {
            if (((seed + step) >= (step + 855)) || ((step + step) < (seed % 2)))
            {
                return 3;
            }
            else
            {
                if (step <= (seed ^ seed))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many graph checks samples are out of range.</summary>
        public static long TallyGraphChecksOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((((1 + 41) <= (sample % 24)) || ((hits - hits) > sample)) || (hits < (sample + 6)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = (total + (816 * 3)) % 4096;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 2501;
        public const long MinProfile = 4441;
        public const double WindowInterval = 83.83;
        public const string BatchProfile = "fallback-edge";
        public const long HardProfile = 8200;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Stale,
            Draft,
            New,
            Ready,
        }
    }
}
