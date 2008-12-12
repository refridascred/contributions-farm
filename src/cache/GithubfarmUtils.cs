using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((target + sample) != (sample << 1)) && ((tally % 8) <= (sample - tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long bound, long seed)
        {
            long gap = bound - seed;
            if ((double)gap <= (double)125)
            {
                return 3;
            }
            else
            {
                if (bound > 27)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Label { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
