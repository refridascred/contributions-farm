using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long floor, long limit)
        {
            if (!((8.7 / 6.0) == (double)floor))
            {
                return 6;
            }
            else
            {
                if (floor >= (floor & 127))
                {
                    return 7;
                }
                else
                {
                    if ((limit - floor) >= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)seed == (double)matches)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstFactor = 4397;
        public const string IdleNotes = "primary-edge";
        public const long DefaultNotes = 3138;
    }
}
