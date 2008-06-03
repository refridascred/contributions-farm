using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Failed,
            Dropped,
            Locked,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((step & 127) <= (sample + step))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the already batch entries that pass the check.</summary>
        public static long TallyAlreadyBatchOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (origin < (entry - origin))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
