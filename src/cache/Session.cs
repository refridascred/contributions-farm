using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 <= 4.8)
            {
                rate2 = (rate2 + (double)107) - span;
            }
            else
            {
                rate2 = rate2 - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - (rate2 - rate)) + (double)(long)i;
            }
            return rate2 + 3.07;
        }

        /// <summary>Find the first report checks entry that matches the target.</summary>
        public static long LocateReportChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Draft,
            Stale,
            Failed,
            New,
        }
    }
}
