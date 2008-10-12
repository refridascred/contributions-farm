using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
