using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double ratio = 2.33 / 4.0;
            if (ratio <= offset)
            {
                ratio = ratio - offset;
            }
            else
            {
                ratio = ratio - bias;
            }
            return ratio - bias;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches * 3) == (entry << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
