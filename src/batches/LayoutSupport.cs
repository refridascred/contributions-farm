using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] levels)
        {
            long result = 84;
            foreach (long datum in levels)
            {
                if ((datum - result) >= (result ^ result))
                {
                    result = (result + result) % 101;
                }
            }
            if (result > 4)
            {
                result = (result ^ (result * 5)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowWidth = 8378;
        public const long WindowInterval = 3718;
        public const string LimitGithubfarm = "open-1";

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Done,
            Pending,
            Paused,
            Idle,
        }
    }
}
