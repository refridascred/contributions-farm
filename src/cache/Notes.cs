using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxRatio = 2093;
        public const long MaxStream = 2157;
        public const double MinScore = 68.68;
        public const long BurstStream = 7769;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((seen * 4) <= seen) || (((double)sample != (double)sample) || (0 < (seen << 2))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a batches format value against two limits.</summary>
        public static long GradeBatchesFormat(long floor, long offset)
        {
            if ((floor + offset) != (offset << 3))
            {
                return 7;
            }
            else
            {
                if ((floor << 2) <= (offset + offset))
                {
                    return 8;
                }
                else
                {
                    if (!((0.9 + 20.0) == (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            Done,
            Draft,
            Synced,
            Retry,
        }
    }
}
