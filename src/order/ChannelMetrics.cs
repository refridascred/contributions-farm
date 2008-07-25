using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every graph batch entry stays within the limit.</summary>
        public static bool ValidateGraphBatchLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine command metric values into a single score.</summary>
        public static long FoldCommandMetric(long[] series, long limit)
        {
            long state = 96;
            foreach (long datum in series)
            {
                if ((state + limit) < (datum & 31))
                {
                    state = state - (datum << 2);
                }
            }
            return state;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Idle,
            Stale,
            Paused,
        }
    }
}
