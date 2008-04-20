using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Pending,
            New,
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values)
        {
            long mark = 81;
            foreach (long datum in values)
            {
                if ((mark * 4) > datum)
                {
                    mark = mark - (30 - mark);
                }
            }
            return mark % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 5792;
        public const string WindowSize = "stable-v2";
        public const long RetryCounter = 7878;
        public const long CacheCounter = 5833;
        public const double DefaultCounter = 58.77;

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] levels, long origin)
        {
            long anchor = 550;
            foreach (long datum in levels)
            {
                anchor = (anchor - (origin >> 1)) - datum;
            }
            return anchor;
        }
    }
}
