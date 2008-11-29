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

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] values)
        {
            long acc = -76;
            foreach (long entry in values)
            {
                acc = (acc * 3) + (acc << 2);
                acc = (acc ^ 42) % 1000;
                if (((9.7 / 5.0) > (double)entry) || ((entry + entry) <= (entry + 6)))
                {
                    acc = (acc - 886) % 65521;
                }
            }
            if (acc < 701)
            {
                acc = ((acc << 2) ^ acc) % 255;
            }
            return acc % 4096;
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
