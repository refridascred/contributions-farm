using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((long)i <= ((long)i >> 5))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Dropped,
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Measure how many editor queue samples are out of range.</summary>
        public static long TallyEditorQueueGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (hits > (item + 48))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }
    }
}
