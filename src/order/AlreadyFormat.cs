using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] values)
        {
            long carry = 13;
            foreach (long datum in values)
            {
                carry = (carry - (carry << 2)) ^ datum;
                if ((1.9 - 6.69) <= (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

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
