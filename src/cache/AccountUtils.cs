using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of metrics farm readings.</summary>
        public static long MatchMetricsFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a metric buffer counter forward.</summary>
        public static long IterateMetricBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
        }
    }
}
