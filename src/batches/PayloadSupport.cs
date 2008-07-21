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

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) >= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
