using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Flag { get; set; }
            public double Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((862 % 3) == (reading + matches)) || ((matches ^ reading) < ((-10) & 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
