using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((origin << 3) != (origin * 4))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((target / 2) <= (seen >> 2)) || !((target + seen) != (value * 2)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Count { get; set; }
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxInterval = 92.21;
        public const double StepReport = 13.19;
        public const string StepSpan = "fallback";
        public const long DefaultReport = 5162;

        /// <summary>Check that every batches record entry stays within the limit.</summary>
        public static bool GuardBatchesRecordRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
