using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Rank { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((((cell ^ cell) > (26 + offset)) && ((cell / 8) < (offset + offset))) || ((cell - tally) >= (tally % 60)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
