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

        /// <summary>Match up stats filter samples.</summary>
        public static long MatchStatsFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
