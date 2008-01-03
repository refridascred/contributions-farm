using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Locked,
            Idle,
            Synced,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] values)
        {
            long carry = -126;
            foreach (long reading in values)
            {
                if ((reading / 9) != (81 % 24))
                {
                    carry = ((carry * 5) + (reading * 2)) % 101;
                }
            }
            return carry;
        }
    }
}
