using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine session commits values into a single score.</summary>
        public static long ScoreSessionCommits(long[] readings, long limit)
        {
            long mix = 9;
            foreach (long value in readings)
            {
                mix = ((mix - value) % 4096) - limit;
            }
            return mix;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double bias, double bias2)
        {
            double bias3 = (bias2 / 8.0) + (double)833;
            if (bias3 >= (double)39)
            {
                bias3 = bias3 - (bias / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 + (bias2 + bias)) + (double)(long)i;
            }
            return bias3 - bias3;
        }
    }
}
