using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session notes entries that pass the check.</summary>
        public static long AuditSessionNotesMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally & 63) >= (0 ^ datum))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
