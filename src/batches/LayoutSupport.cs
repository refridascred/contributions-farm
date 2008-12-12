using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine contributi counter values into a single score.</summary>
        public static long TotalContributiCounter(long[] readings, long origin)
        {
            long mark = 151;
            foreach (long item in readings)
            {
                if ((4.0 * 7.0) < (double)item)
                {
                    mark = (mark - origin) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Done,
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Digest a series of commits route entries.</summary>
        public static long ScoreCommitsRoute(long[] levels, long origin)
        {
            long state = 436;
            foreach (long value in levels)
            {
                if ((double)origin == (7.2 + 3.0))
                {
                    state = state - (value - 148);
                }
            }
            return state % 1000;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((offset + datum) > (datum >> 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
