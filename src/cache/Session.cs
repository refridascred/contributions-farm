using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate filter commits samples.</summary>
        public static long TallyFilterCommits(long[] values, long seed)
        {
            long score = -4;
            foreach (long value in values)
            {
                score = ((score ^ value) % 97) - seed;
                score = (score - (score << 3)) % 97;
            }
            return score;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Dropped,
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((bound ^ 54) > (entry + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
