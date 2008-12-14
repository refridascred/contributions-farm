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

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
