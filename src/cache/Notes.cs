using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Label { get; set; }
            public double Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit schema session readings against a rule.</summary>
        public static long MeasureSchemaSessionGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (5.6 - 0.7))
                {
                    matches = (matches + 3) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many report buffer samples are out of range.</summary>
        public static long AuditReportBufferGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((seen & 127) >= (bound % 3)) && ((seen >> 1) <= (cell + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Pending,
            Stale,
            Draft,
            Idle,
        }
    }
}
