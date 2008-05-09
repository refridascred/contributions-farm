using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((4.17 * 8.0) >= (double)matches)
                {
                    matches = ((matches + 1) + reading) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
