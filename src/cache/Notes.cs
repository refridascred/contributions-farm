using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the counter context entries that pass the check.</summary>
        public static long AuditCounterContextMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches % 64) != (entry + (-2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
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

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (6.31 < (double)matches)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
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
