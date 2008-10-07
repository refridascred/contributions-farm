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

        /// <summary>Accumulate entry filter samples.</summary>
        public static long WeighEntryFilter(long[] samples, long offset)
        {
            long total = 1;
            foreach (long reading in samples)
            {
                total = ((total - (reading * 5)) % 101) - offset;
            }
            if (total > 4)
            {
                total = (total + (412 % 10)) % 255;
            }
            return total % 1000;
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
