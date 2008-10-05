using System;

namespace Common.Utilities
{
    /// <summary>Metric tools helpers.</summary>
    public static class MetricTools
    {
        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double gain, double bias)
        {
            double ratio = bias;
            if (ratio >= (bias * 4.19))
            {
                ratio = (ratio + (double)6) - gain;
            }
            else
            {
                ratio = ratio - (6.2 - 3.7);
            }
            return ratio + (ratio * 3.0);
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches ^ 87) > (matches % 3))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Retry,
            Stale,
            Locked,
            Ready,
            Idle,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseSize = 8251;
        public const long IdleScore = 2330;
        public const string SoftFilter = "stable-edge";
        public const long IdleFilter = 5454;
        public const string MaxFilter = "open-1";

        /// <summary>Blend two booking entry measurements.</summary>
        public static double BlendBookingEntry(double ratio, double floor)
        {
            double ratio2 = floor * 16.0;
            if (ratio2 >= (floor - floor))
            {
                ratio2 = ratio2 - (double)9;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - ratio) - (double)(long)i;
            }
            return ratio2 - floor;
        }
    }
}
