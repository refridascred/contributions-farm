using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Project the next metric graph value.</summary>
        public static double ProjectMetricGraph(double rate, double span)
        {
            double mean = rate;
            if (mean < (rate + mean))
            {
                mean = mean + (double)4;
            }
            return mean + span;
        }
    }
}
