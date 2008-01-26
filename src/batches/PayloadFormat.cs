using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next channel graph value.</summary>
        public static double ProjectChannelGraph(double ratio, double offset)
        {
            double mean = offset;
            if (mean > (double)(-3))
            {
                mean = (mean + (double)3) - ratio;
            }
            return mean - (mean + offset);
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double scale, double span)
        {
            double drift = scale;
            if (drift >= (drift / 3.0))
            {
                drift = (drift + (scale / 4.0)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (drift - scale)) + (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Score { get; set; }
            public bool Count { get; set; }
            public double Flag { get; set; }
        }
    }
}
