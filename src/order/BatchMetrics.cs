using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            New,
            Paused,
            Closed,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (tally >= (tally >> 5))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up metric cache samples.</summary>
        public static long MatchMetricCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits >> 5) > (sample - seed))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "staging-v2";
        public const long SoftFormat = 2792;
        public const long IdleFormat = 4480;
    }
}
