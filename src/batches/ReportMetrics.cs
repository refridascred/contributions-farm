using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] levels)
        {
            long carry = 266;
            foreach (long value in levels)
            {
                carry = carry ^ (value ^ value);
            }
            return carry;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Draft,
            Stale,
            Synced,
            Dropped,
        }
    }
}
