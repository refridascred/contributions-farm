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

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long bound, long floor)
        {
            long bound2 = bound - floor;
            if ((double)bound > (double)bound2)
            {
                return 6;
            }
            else
            {
                if ((double)floor < 2.0)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
