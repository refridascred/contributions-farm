using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every notes editor entry stays within the limit.</summary>
        public static bool CheckNotesEditorBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Active,
            Failed,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long floor, long target)
        {
            if ((double)target >= (19.0 + 4.05))
            {
                return 8;
            }
            else
            {
                if (floor < (target ^ floor))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 1490;
        public const double IdleSize = 14.02;
        public const long WindowTimeout = 2786;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Label { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
