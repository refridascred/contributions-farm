using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Failed,
            Queued,
            Pending,
            New,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] samples, long limit)
        {
            long mark = 19;
            foreach (long reading in samples)
            {
                mark = (mark - limit) ^ reading;
                if ((long)samples.Length > (1 << 1))
                {
                    break;
                }
            }
            if (mark < 0)
            {
                mark = mark - (236 & 3);
            }
            return mark;
        }

        /// <summary>Scale a route token figure with a bias.</summary>
        public static double AdjustRouteToken(double rate, double floor)
        {
            double load = rate;
            if (load >= (load / 7.0))
            {
                load = (load - rate) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (load + rate);
        }
    }
}
