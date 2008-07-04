using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Closed,
            Draft,
            Locked,
        }

        /// <summary>Audit stats layout readings against a rule.</summary>
        public static long MeasureStatsLayoutGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((((item + count) > step) && (count <= (step - step))) && (((double)step > (double)item) || ((7 / 5) < (item / 8))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public bool Token { get; set; }
            public bool Owner { get; set; }
        }
    }
}
