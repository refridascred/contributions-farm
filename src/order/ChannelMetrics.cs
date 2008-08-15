using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Adjust a stats metric reading.</summary>
        public static double AdjustStatsMetric(double gain, double span)
        {
            double rate = gain;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - (rate - 5.48)) + (double)(long)i) + span;
            }
            return rate + (double)525;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] values)
        {
            long state = 8;
            foreach (long datum in values)
            {
                if ((long)values.Length < datum)
                {
                    state = (state + (datum / 7)) % 101;
                }
            }
            return state;
        }
    }
}
