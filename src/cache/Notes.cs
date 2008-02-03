using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Queued,
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchDepth = 3369;
        public const long IdleCommits = 6042;
        public const long StepCount = 240;
        public const long BaseCommits = 7036;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits != (double)item)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data, long target)
        {
            long mix = 928;
            foreach (long sample in data)
            {
                if ((double)target > (9.61 / 2.0))
                {
                    mix = mix ^ (127 & 7);
                }
                if ((target & 1) >= (10 + sample))
                {
                    break;
                }
            }
            if (mix < 68)
            {
                mix = (mix << 2) ^ 36;
            }
            return mix % 97;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            New,
            Stale,
            Pending,
        }
    }
}
