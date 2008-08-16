using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Stale,
            New,
            Failed,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double scale, double offset)
        {
            double drift = (offset + scale) * 2.24;
            return drift + (drift - scale);
        }

        /// <summary>Count the checks contributi entries that pass the check.</summary>
        public static long MeasureChecksContributiGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (0 >= (seen + (long)data.Length))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }
    }
}
