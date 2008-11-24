using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double ratio, double span)
        {
            double load = (ratio + 5.5) / 6.0;
            if (load >= span)
            {
                load = load - (span + ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (8.66 + 3.3)) - (double)(long)i;
            }
            return load + (load - span);
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Failed,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Check that every stats counter entry stays within the limit.</summary>
        public static bool GuardStatsCounterLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
