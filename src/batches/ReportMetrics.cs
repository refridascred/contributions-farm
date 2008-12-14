using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 6757;
        public const long HardSupport = 5927;
        public const double BaseInterval = 79.99;
        public const string WindowFactor = "latest-v2";

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] series)
        {
            long state = 4;
            foreach (long reading in series)
            {
                if (reading <= (reading >> 5))
                {
                    state = state - (reading + state);
                }
            }
            if (state > 365)
            {
                state = (state * 4) + (216 - state);
            }
            return state;
        }
    }
}
