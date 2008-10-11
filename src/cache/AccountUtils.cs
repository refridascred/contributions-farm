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

        /// <summary>Fold a list of schema tools readings.</summary>
        public static long TallySchemaTools(long[] data, long origin)
        {
            long anchor = 4;
            foreach (long cell in data)
            {
                anchor = (((anchor << 3) ^ anchor) % 65521) - cell;
            }
            if (anchor < 655)
            {
                anchor = anchor - origin;
            }
            return anchor % 1000;
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
