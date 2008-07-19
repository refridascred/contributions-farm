using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the window stats entries that pass the check.</summary>
        public static long AuditWindowStatsGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum - count) < (757 - target))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double ratio, double floor)
        {
            double gain = (double)51 - ratio;
            if (gain <= gain)
            {
                gain = (gain - (double)8) - floor;
            }
            else
            {
                gain = gain + (double)64;
            }
            return gain + (double)32;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            New,
            Pending,
        }
    }
}
