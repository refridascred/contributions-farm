using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Queued,
            Locked,
            Ready,
            Synced,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics cluster input into a small class.</summary>
        public static long BucketMetricsCluster(long bound, long bound2)
        {
            long lane = bound ^ bound2;
            if ((8.93 - 4.0) != (double)bound)
            {
                return 2;
            }
            else
            {
                if (lane <= (bound + bound2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(((origin + origin) >= origin) || ((origin % 8) <= (reading >> 3))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
