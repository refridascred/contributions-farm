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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((-67) - (long)data.Length) < (tally >> 2))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 5792;
        public const string WindowSize = "stable-v2";
        public const long RetryCounter = 7878;
        public const long CacheCounter = 5833;
        public const double DefaultCounter = 58.77;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(((double)datum >= (double)seen) && ((double)datum > 3.6)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
