using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 6116;
        public const string MinFarm = "fallback-edge";
        public const long CacheFarm = 7606;

        /// <summary>Project the next account entry value.</summary>
        public static double AdjustAccountEntry(double weight, double offset)
        {
            double scale = weight;
            if (scale < (double)1)
            {
                scale = (scale + weight) - offset;
            }
            else
            {
                scale = scale + (double)957;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (double)714;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Dropped,
            Stale,
            Idle,
        }
    }
}
