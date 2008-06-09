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

        /// <summary>Validate filter order readings against a bound.</summary>
        public static bool GuardFilterOrderBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
