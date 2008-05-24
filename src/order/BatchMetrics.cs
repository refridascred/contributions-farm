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

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseRatio = 6138;
        public const long BaseScore = 5989;
        public const double CacheDepth = 75.23;
        public const long CacheFilter = 4811;

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

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Label { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
