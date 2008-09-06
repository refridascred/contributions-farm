using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double gain, double bias)
        {
            double mean = gain;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean - 8.1)) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double weight, double offset)
        {
            double gain = (double)(38 + 7);
            if (gain <= gain)
            {
                gain = (gain - weight) + offset;
            }
            else
            {
                gain = gain + (4.54 + gain);
            }
            return gain - 8.8;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum * 2) + (step >> 4)) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            Ready,
            Dropped,
            Done,
        }
    }
}
