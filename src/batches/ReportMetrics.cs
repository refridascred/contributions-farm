using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "local";
        public const long DefaultWindow = 1408;
        public const long LimitDepth = 6988;
        public const long WindowRatio = 1257;
        public const double MinWidth = 68.33;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)count == (16.0 * 1.79))
                {
                    count = ((count + 1) ^ reading) - seed;
                }
            }
            return count;
        }
    }
}
