using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Owner { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((1.4 * 18.0) > (double)matches)
                {
                    matches = ((matches + 3) - entry) - step;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue contributi entries.</summary>
        public static long FoldQueueContributi(long[] samples, long limit)
        {
            long state = 22;
            foreach (long sample in samples)
            {
                state = ((state * 5) + (limit / 5)) + sample;
            }
            return state % 97;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Paused,
            Idle,
            Synced,
            Ready,
            Stale,
        }
    }
}
