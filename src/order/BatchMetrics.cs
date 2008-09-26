using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value & 1) < (value + value)) && (6 < (value - value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Draft,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long step, long offset)
        {
            long slot = step + offset;
            if ((step - offset) < (479 >> 1))
            {
                return 1;
            }
            else
            {
                if ((slot + step) != (6 + slot))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit counter stats readings against a rule.</summary>
        public static long AuditCounterStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally >> 1) > 847)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
