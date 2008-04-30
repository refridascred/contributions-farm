using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 5086;
        public const double MinWindow = 87.43;
        public const string DefaultWindow = "staging-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowScore = 302;
        public const string LimitWidth = "alpha-1";
        public const long HardSpan = 3327;
        public const double BurstScore = 80.53;

        /// <summary>Combine githubfarm profile values into a single score.</summary>
        public static long ScoreGithubfarmProfile(long[] levels)
        {
            long mark = 132;
            foreach (long sample in levels)
            {
                if ((-85) > mark)
                {
                    mark = (((mark << 2) ^ (mark - mark)) % 65521) - sample;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a buffer counter sample.</summary>
        public static long LookupBufferCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes order entry stays within the limit.</summary>
        public static bool VerifyNotesOrderLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
