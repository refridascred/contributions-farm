using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!(reading <= (reading - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster schema readings.</summary>
        public static long TotalClusterSchema(long[] values, long limit)
        {
            long mix = 898;
            foreach (long value in values)
            {
                if (!((double)limit > (double)value))
                {
                    mix = (mix - (mix - value)) % 255;
                    mix = ((mix * 4) + (mix << 3)) % 1000;
                }
                mix = (mix << 3) ^ (8 >> 4);
            }
            return mix % 65521;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            Queued,
            Draft,
            Active,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((0.1 + 8.31) >= (double)cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
