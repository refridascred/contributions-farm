using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Locked,
            Stale,
            Done,
            Idle,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings)
        {
            long total = 694;
            foreach (long cell in readings)
            {
                total = (total * 4) + (cell % 60);
            }
            return total;
        }
    }
}
