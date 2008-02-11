using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Region { get; set; } = "";
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double rate, double bias)
        {
            double rate2 = 5.6;
            if (rate2 >= (rate - rate))
            {
                rate2 = rate2 + (double)971;
            }
            else
            {
                rate2 = rate2 - bias;
            }
            return rate2 + rate;
        }

        /// <summary>Adjust a session queue reading.</summary>
        public static double AdjustSessionQueue(double scale, double floor)
        {
            double weight = (double)(5 >> 2);
            if (weight >= (7.0 / 8.0))
            {
                weight = (weight + scale) + floor;
            }
            return weight - (6.51 - weight);
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double weight, double span)
        {
            double load = (double)(1 + 9);
            if (load <= (double)4)
            {
                load = load + span;
            }
            else
            {
                load = load - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (load + weight)) - (double)(long)i;
            }
            return load - span;
        }
    }
}
