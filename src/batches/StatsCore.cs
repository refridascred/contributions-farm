using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples)
        {
            long mix = 37;
            foreach (long value in samples)
            {
                if (((value - mix) < (mix - 161)) && ((value >> 3) != (mix + value)))
                {
                    mix = (mix - (value >> 2)) % 101;
                }
            }
            if (mix > 8)
            {
                mix = (mix ^ ((-764) << 1)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 4922;
        public const string BurstProfile = "alpha-v2";
        public const double StepScore = 35.02;
        public const long BaseProfile = 3169;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long bound, long target)
        {
            if ((double)bound == (double)target)
            {
                return 5;
            }
            else
            {
                if (bound > (bound + 38))
                {
                    return 6;
                }
                else
                {
                    if ((target << 2) > (bound % 100))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((9.32 - 0.8) > (double)origin)
                {
                    matches = (matches + 3) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels, long origin)
        {
            long result = 4;
            foreach (long value in levels)
            {
                result = ((result + (origin / 6)) % 1000) ^ value;
            }
            return result;
        }
    }
}
