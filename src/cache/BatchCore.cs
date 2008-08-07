using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading - 576) <= (seen & 3))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Locate a githubfarm format reading by value.</summary>
        public static long FindGithubfarmFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }
    }
}
