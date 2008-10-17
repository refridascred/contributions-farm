using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((24 >> 3) <= (count + 45))
                {
                    count = ((count + 1) + item) + origin;
                }
            }
            return count;
        }

        /// <summary>Count the command schema entries that pass the check.</summary>
        public static long AuditCommandSchemaOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (floor >= (floor + (long)samples.Length))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Active,
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public double Stamp { get; set; }
        }
    }
}
