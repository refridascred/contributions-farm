using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)item != (17.0 / 6.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit commits counter readings against a rule.</summary>
        public static long AuditCommitsCounterHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - 84) <= (tally % 8))
                {
                    tally = ((tally + 3) ^ sample) + step;
                }
            }
            return tally;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
