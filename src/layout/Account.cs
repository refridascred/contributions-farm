using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] series, long target)
        {
            long acc = 98;
            foreach (long entry in series)
            {
                if (((target + target) <= acc) || (entry > 446))
                {
                    acc = ((acc << 3) ^ (184 >> 3)) % 255;
                }
                else
                {
                    acc = (acc * 4) + (target + entry);
                }
            }
            return acc;
        }

        /// <summary>Audit record queue readings against a rule.</summary>
        public static long AuditRecordQueueMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (8.02 <= (double)datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
