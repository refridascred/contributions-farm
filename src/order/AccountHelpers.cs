using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor - (origin << 2)) % 1000;
                anchor = (anchor * 3) + origin;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor ^ (anchor << 2)) % 101) - (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseSize = "staging-1";
        public const long DefaultCounter = 9651;
        public const long BurstCount = 7935;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            New,
            Paused,
            Retry,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((((seen + seen) > (seed / 7)) && (seen < (entry / 8))) && (7.99 <= (double)seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 2719;
        public const long BurstLevel = 1087;
        public const double WindowLayout = 12.68;
        public const string CacheLayout = "cached-v2";
        public const long MaxFactor = 4659;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Paused,
            Closed,
            Queued,
        }
    }
}
