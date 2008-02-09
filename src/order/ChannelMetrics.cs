using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
