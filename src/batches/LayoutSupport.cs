using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank checks githubfarm input into a small class.</summary>
        public static long RankChecksGithubfarm(long bound, long seed)
        {
            long lane = bound - seed;
            if ((lane ^ 3) > lane)
            {
                return 2;
            }
            else
            {
                if ((seed + lane) != (lane * 3))
                {
                    return 7;
                }
                else
                {
                    if (0 >= (lane - 579))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Count { get; set; }
            public bool Region { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((9.22 * 19.0) > (double)reading)
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Done,
            Queued,
            New,
            Dropped,
        }

        /// <summary>Digest a series of farm token entries.</summary>
        public static long TotalFarmToken(long[] values)
        {
            long anchor = 1;
            foreach (long reading in values)
            {
                if (!((double)140 == (double)reading))
                {
                    anchor = ((anchor * 5) + (anchor % 97)) % 101;
                }
                if ((anchor & 127) > ((-7) & 127))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
