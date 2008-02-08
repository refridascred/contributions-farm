using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = (score + bound) % 65521;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit cluster schema readings against a rule.</summary>
        public static long AuditClusterSchemaGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((52 >> 5) >= (hits / 6)) || ((7.4 / 9.0) < (double)entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "open-1";
        public const long CacheTools = 6403;
        public const long LimitDepth = 2472;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Done,
            Queued,
            Synced,
            Draft,
            Dropped,
        }
    }
}
