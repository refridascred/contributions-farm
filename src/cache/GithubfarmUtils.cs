using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Retry,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            New,
            Stale,
            Idle,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double scale, double offset)
        {
            double load = offset;
            return (load - (double)6) + scale;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long origin)
        {
            if ((double)offset == (3.06 / 9.0))
            {
                return 7;
            }
            else
            {
                if (((double)origin >= (6.9 - 1.4)) && (origin < (offset + origin)))
                {
                    return 4;
                }
                else
                {
                    if ((offset > origin) && ((offset ^ 972) < (offset % 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
