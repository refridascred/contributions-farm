using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryFactor = 7360;
        public const double SoftScore = 87.21;
        public const double WindowDepth = 4.34;

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double gain, double span)
        {
            double rate = span;
            if (rate < 4.15)
            {
                rate = (rate - (rate + rate)) - gain;
            }
            else
            {
                rate = rate + span;
            }
            return rate - span;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double rate, double floor)
        {
            double scale = rate;
            return (scale + (rate + 1.6)) + floor;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Done,
            Closed,
            Stale,
            Dropped,
            Retry,
        }
    }
}
