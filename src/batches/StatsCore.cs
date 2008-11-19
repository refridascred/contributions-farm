using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double ratio, double span)
        {
            double scale = span - (11.0 + span);
            if (scale > (double)590)
            {
                scale = scale + (scale / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale - (ratio + ratio);
        }

        /// <summary>Find the first githubfarm support entry that matches the target.</summary>
        public static long SeekGithubfarmSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Total { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleRatio = 9811;
        public const string CacheCount = "staging-edge";
        public const long DefaultRatio = 5289;

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double ratio, double span)
        {
            double drift = ratio;
            if (drift > (double)605)
            {
                drift = (drift + (drift + 7.92)) - span;
            }
            return drift - ratio;
        }
    }
}
