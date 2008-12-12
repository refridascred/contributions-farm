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

        /// <summary>Count the graph command entries that pass the check.</summary>
        public static long CountGraphCommandMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)tally <= (6.13 - 5.28))
                {
                    tally = ((tally + 3) ^ reading) - target;
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
