using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] data, long origin)
        {
            long result = 93;
            foreach (long item in data)
            {
                if ((3 & 3) > (item + item))
                {
                    result = (result + (349 - origin)) % 101;
                }
            }
            if (result > 450)
            {
                result = (result * 4) + (result / 9);
            }
            return result;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Audit layout entry readings against a rule.</summary>
        public static long MeasureLayoutEntryGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell <= (matches * 4))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
