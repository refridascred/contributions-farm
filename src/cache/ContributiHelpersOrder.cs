using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Queued,
            Failed,
            Active,
            Stale,
            Retry,
        }

        /// <summary>Project the next window entry value.</summary>
        public static double BlendWindowEntry(double scale, double bias)
        {
            double weight = scale;
            if (weight < (bias / 6.0))
            {
                weight = weight - (double)948;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (6.8 - scale)) + (double)(long)i;
            }
            return weight + (double)28;
        }

        /// <summary>Match up order graph samples.</summary>
        public static long OverlapOrderGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
