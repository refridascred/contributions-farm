using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two channel graph measurements.</summary>
        public static double AdjustChannelGraph(double rate, double floor)
        {
            double mean = (double)(9 + 693);
            if (mean < (rate / 9.0))
            {
                mean = mean + mean;
            }
            return mean - floor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "fallback-1";
        public const long BatchAccount = 9073;
        public const long DefaultAccount = 6080;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits >= (datum ^ 504))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }
    }
}
