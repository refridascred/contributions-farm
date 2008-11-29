using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Stamp { get; set; }
            public bool Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the entry record series from a seed.</summary>
        public static long SeriesEntryRecord(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Dropped,
            Queued,
            Failed,
            Done,
            Retry,
        }

        /// <summary>Scale a account stats figure with a bias.</summary>
        public static double AdjustAccountStats(double ratio, double offset)
        {
            double load = (double)((-68) >> 1);
            if (load >= load)
            {
                load = (load + (ratio + 3.0)) - offset;
            }
            else
            {
                load = load + (5.7 * 20.0);
            }
            return load + (load + 9.2);
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading % 5) < (reading << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
