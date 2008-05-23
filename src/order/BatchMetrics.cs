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

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count * 2) != (target + count))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
