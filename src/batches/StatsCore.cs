using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Region { get; set; }
            public double Flag { get; set; }
            public string Label { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            New,
            Idle,
            Synced,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftSize = "fallback";
        public const long StepGithubfarm = 9222;
        public const long DefaultTimeout = 3419;
        public const long LimitGithubfarm = 4016;
        public const string RetryLevel = "standard-v2";

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix << 3) ^ step) % 97;
                mix = (mix ^ (mix * 5)) % 97;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Done,
            Active,
            Queued,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] values)
        {
            long result = 7;
            foreach (long cell in values)
            {
                result = (result - ((-717) % 60)) % 101;
                if ((4.47 * 4.4) != (double)cell)
                {
                    result = ((result << 2) ^ (212 + 61)) % 1000;
                }
            }
            return result;
        }
    }
}
