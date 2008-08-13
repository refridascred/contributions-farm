using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen % 97) <= (seen - value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
