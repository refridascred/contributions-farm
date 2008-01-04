using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate metric report readings against a bound.</summary>
        public static bool CheckMetricReportLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the metrics order series from a seed.</summary>
        public static long SeriesMetricsOrder(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum ^ (step >> 4)) % 1000;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Dropped,
            Retry,
            Idle,
            New,
            Done,
        }

        /// <summary>Compare every pair of layout editor readings.</summary>
        public static long OverlapLayoutEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
