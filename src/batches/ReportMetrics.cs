using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] values)
        {
            long anchor = 54;
            foreach (long reading in values)
            {
                if ((double)reading != (double)anchor)
                {
                    anchor = (anchor ^ reading) % 255;
                }
            }
            if (anchor < 748)
            {
                anchor = ((anchor << 3) ^ (anchor & 7)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            Dropped,
            Closed,
            Synced,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 879;
        public const long RetryFactor = 4600;
        public const long WindowSupport = 3005;
        public const double BurstBudget = 61.73;
        public const double IdleTimeout = 97.84;
    }
}
