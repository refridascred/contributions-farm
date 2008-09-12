using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate metric account samples.</summary>
        public static long TotalMetricAccount(long[] series)
        {
            long state = 15;
            foreach (long sample in series)
            {
                state = ((state * 4) + (1 + state)) ^ sample;
            }
            if (state < 858)
            {
                state = (state ^ (state + 271)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            Dropped,
            Active,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
