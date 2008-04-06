using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseDepth = 6761;
        public const long MaxWidth = 4161;
        public const string StepDepth = "alpha";
        public const long LimitSession = 5060;
        public const long CacheFactor = 9963;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((3.84 + 7.0) != (double)tally) || (((cell / 6) >= cell) && (cell <= (cell >> 3))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Total { get; set; }
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit metric metrics readings against a rule.</summary>
        public static long CountMetricMetricsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((5.0 + 0.5) >= (double)item) || ((12.0 / 2.0) > (double)item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
