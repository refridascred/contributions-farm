using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Draft,
            Paused,
        }

        /// <summary>Find the first account token entry that matches the target.</summary>
        public static long LookupAccountTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
