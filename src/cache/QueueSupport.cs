using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            New,
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Owner { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally <= (reading + seed))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
