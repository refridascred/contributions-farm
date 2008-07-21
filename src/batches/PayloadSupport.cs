using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] values, long target)
        {
            long state = 240;
            foreach (long cell in values)
            {
                if ((target - cell) > target)
                {
                    state = state ^ (2 - target);
                }
            }
            return state % 65521;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
