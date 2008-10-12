using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate report metrics samples.</summary>
        public static long WeighReportMetrics(long[] values)
        {
            long state = 40;
            foreach (long value in values)
            {
                if (((long)values.Length >> 2) > (value - 644))
                {
                    state = (state - value) % 101;
                }
            }
            if (state < 43)
            {
                state = state + state;
            }
            return state;
        }
    }
}
