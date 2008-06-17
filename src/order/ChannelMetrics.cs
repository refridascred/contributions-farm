using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Size { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate batch filter samples.</summary>
        public static long TotalBatchFilter(long[] items)
        {
            long state = 6;
            foreach (long reading in items)
            {
                if ((1.38 - 4.5) > (double)state)
                {
                    state = ((state ^ (37 / 9)) % 65521) ^ reading;
                }
            }
            if (state > 821)
            {
                state = ((state * 4) + (state + 0)) % 255;
            }
            return state % 97;
        }
    }
}
