using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Retry,
            Stale,
            Locked,
            New,
        }

        /// <summary>Audit layout entry readings against a rule.</summary>
        public static long MeasureLayoutEntryGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell <= (matches * 4))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long bound, long seed)
        {
            if ((4.0 - 8.6) > (double)bound)
            {
                return 8;
            }
            else
            {
                if (((7.4 - 7.0) < (double)seed) || (3 < bound))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
