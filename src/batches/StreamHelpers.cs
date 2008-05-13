using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleTimeout = 62.52;
        public const double BurstEditor = 87.39;
        public const long LimitDepth = 9756;

        /// <summary>Locate a filter channel reading by value.</summary>
        public static long LookupFilterChannelIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Idle,
            Active,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            New,
            Failed,
            Paused,
            Done,
        }

        /// <summary>Scale a route batches figure with a bias.</summary>
        public static double SmoothRouteBatches(double weight, double bias)
        {
            double ratio = bias;
            if (ratio >= ratio)
            {
                ratio = (ratio - (double)275) - weight;
            }
            else
            {
                ratio = ratio - (bias - ratio);
            }
            return ratio - bias;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double bias, double bias2)
        {
            double weight = bias * 9.0;
            if (weight <= (weight - weight))
            {
                weight = weight - (bias - bias2);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (double)654;
        }
    }
}
