using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many stream profile samples are out of range.</summary>
        public static long TallyStreamProfileGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry & 7) < (629 * 3))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Stale,
            Draft,
            Done,
        }
    }
}
