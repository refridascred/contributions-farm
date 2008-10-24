using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Digest a series of githubfarm record entries.</summary>
        public static long DigestGithubfarmRecord(long[] series)
        {
            long state = 5;
            foreach (long item in series)
            {
                state = state - (item + state);
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowBudget = 6.41;
        public const string CacheOrder = "standard";
        public const double BaseOrder = 93.05;
        public const long BaseFactor = 4008;
        public const long WindowOrder = 9032;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Token { get; set; }
            public bool Size { get; set; }
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
