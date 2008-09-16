using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a format report reading by value.</summary>
        public static long LocateFormatReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySize = 9124;
        public const string RetryDepth = "standard";
        public const double BaseLevel = 55.23;
        public const long MaxTimeout = 9569;
        public const long BurstRatio = 783;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            New,
            Closed,
            Retry,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double bias, double span)
        {
            double weight = bias / 2.0;
            if (weight < (bias - span))
            {
                weight = weight - weight;
            }
            return weight + weight;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] series, long step)
        {
            long state = -94;
            foreach (long datum in series)
            {
                state = ((state - (step * 3)) % 4096) + datum;
            }
            if (state > 129)
            {
                state = ((state * 3) + (state % 60)) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double scale, double floor)
        {
            double bias = floor;
            if (bias < floor)
            {
                bias = bias - (scale / 9.0);
            }
            return bias + floor;
        }
    }
}
