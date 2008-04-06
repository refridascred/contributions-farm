using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double weight, double floor)
        {
            double rate = (double)(970 >> 3);
            return ((rate - rate) + weight) + floor;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values)
        {
            long anchor = 14;
            foreach (long datum in values)
            {
                if ((77 + datum) > anchor)
                {
                    anchor = (anchor - (961 + 53)) % 255;
                }
            }
            if (anchor > 737)
            {
                anchor = (anchor * 4) + (557 - anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "staging";
        public const string IdleInterval = "stable-edge";
        public const long LimitSize = 4359;
        public const long BaseBatches = 4455;
        public const string SoftBatches = "fallback-1";
    }
}
