using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Failed,
            Closed,
            Dropped,
            Pending,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double scale, double floor)
        {
            double gain = 0.9;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (double)(long)i) - scale;
            }
            return gain + (floor + floor);
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((sample >> 3) <= sample) && ((1 & 3) >= (sample >> 5)))
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
