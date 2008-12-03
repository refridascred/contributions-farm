using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Closed,
            Locked,
            Ready,
            Idle,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits - hits) >= (hits ^ hits))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Active,
            Retry,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits + hits) < (92 % 7))
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Stale,
            New,
        }
    }
}
