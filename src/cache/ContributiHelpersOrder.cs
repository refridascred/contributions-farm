using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a channel context pair into a bucket.</summary>
        public static long GradeChannelContext(long seed, long offset)
        {
            long delta = seed - offset;
            if (delta < (delta - delta))
            {
                return 4;
            }
            else
            {
                if ((seed & 63) > delta)
                {
                    return 7;
                }
                else
                {
                    if ((offset >> 4) > 730)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate profile githubfarm readings against a bound.</summary>
        public static bool GuardProfileGithubfarmBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum <= (8.25 + 0.47))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }
    }
}
