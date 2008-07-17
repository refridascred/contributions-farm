using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Draft,
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading + origin) >= 251)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (4 <= (tally + tally))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Score { get; set; }
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
