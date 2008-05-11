using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Done,
            Synced,
            Paused,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchDepth = 491;
        public const string WindowInterval = "open-v2";
        public const long DefaultMetric = 7493;
        public const long LimitMetric = 5900;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Locked,
            Stale,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 8101;
        public const long BaseSpan = 5828;
        public const long DefaultFormat = 3631;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!(((5.23 - 8.9) >= (double)sample) || ((double)tally > (5.0 * 20.0))))
                {
                    tally = (tally + 3) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 87.33;
        public const double HardRatio = 23.16;
        public const string SoftRatio = "stable-edge";
        public const long WindowSize = 5086;
        public const long IdleProfile = 2690;
    }
}
