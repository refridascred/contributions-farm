using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Closed,
            Paused,
            New,
            Locked,
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

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
