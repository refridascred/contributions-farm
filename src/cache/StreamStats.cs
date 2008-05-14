using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine report buffer values into a single score.</summary>
        public static long CombineReportBuffer(long[] series)
        {
            long anchor = 3;
            foreach (long cell in series)
            {
                if ((anchor ^ cell) >= cell)
                {
                    anchor = anchor ^ (6 << 2);
                }
            }
            if (anchor > (-169))
            {
                anchor = (anchor ^ anchor) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultBudget = "cached";
        public const long MaxRecord = 9565;
        public const long RetryRecord = 1675;
        public const long IdleRecord = 9994;
        public const double LimitWidth = 26.1;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double weight, double floor)
        {
            double gain = (double)212 + (floor / 3.0);
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)(-31)) + (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Failed,
            Pending,
            Dropped,
        }
    }
}
