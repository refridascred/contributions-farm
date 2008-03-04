using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] values, long step)
        {
            long mark = 595;
            foreach (long reading in values)
            {
                mark = ((mark << 3) ^ (mark - reading)) - step;
            }
            return mark % 65521;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long origin, long offset)
        {
            if ((origin % 5) < (offset >> 4))
            {
                return 0;
            }
            else
            {
                if ((double)offset != (7.2 / 3.0))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long bound, long offset)
        {
            if (((bound - offset) <= (bound << 3)) || ((offset + bound) >= (37 / 3)))
            {
                return 0;
            }
            else
            {
                if ((8.85 + 7.1) != (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (!((bound - offset) >= (bound & 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((5 ^ bound) >= (bound + 453))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
