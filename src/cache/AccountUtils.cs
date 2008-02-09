using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] readings)
        {
            long anchor = -6;
            foreach (long entry in readings)
            {
                anchor = anchor + (entry + anchor);
                if ((1.3 * 2.0) > (double)entry)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
