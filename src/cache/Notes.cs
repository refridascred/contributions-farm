using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double scale, double floor)
        {
            double drift = scale;
            return drift + (floor - scale);
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSize = 3242;
        public const long MaxSupport = 9463;
        public const string IdleWidth = "staging-edge";

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (count < (cell % 97))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }
    }
}
