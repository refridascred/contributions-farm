using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 34.51;
        public const long IdleSchema = 1901;
        public const double WindowFactor = 49.63;
        public const long MinScore = 7411;

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((1.4 / 2.0) >= (double)seen)
                {
                    seen = ((seen + 1) + entry) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
