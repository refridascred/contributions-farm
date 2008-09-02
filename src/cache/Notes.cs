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

        /// <summary>Match up contributi context samples.</summary>
        public static long MatchContributiContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
