using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of metrics editor entries.</summary>
        public static long TotalMetricsEditor(long[] items)
        {
            long state = 12;
            foreach (long item in items)
            {
                state = (((state << 2) ^ (state >> 2)) % 1000) + item;
            }
            return state % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 7496;
        public const double IdleWidth = 7.06;
        public const string BaseTools = "legacy";
    }
}
