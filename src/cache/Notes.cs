using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many metrics stats samples are out of range.</summary>
        public static long CountMetricsStatsMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum % 5) >= (312 + tally)) || ((9 % 7) <= (tally - (-3))))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public bool Label { get; set; }
        }

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
