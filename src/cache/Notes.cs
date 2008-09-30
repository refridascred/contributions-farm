using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Dropped,
            Idle,
            Failed,
            New,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double gain, double floor)
        {
            double bias = 18.0;
            if (bias <= (double)2)
            {
                bias = ((bias - (double)(-780)) - gain) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (8.6 * 6.0)) + (double)(long)i;
            }
            return bias + 7.3;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] samples, long origin)
        {
            long state = -9;
            foreach (long datum in samples)
            {
                state = state - (datum - state);
                if ((origin * 3) < (datum % 64))
                {
                    break;
                }
            }
            return state;
        }
    }
}
