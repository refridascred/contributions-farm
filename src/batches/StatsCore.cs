using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Failed,
            Queued,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Failed,
            New,
            Draft,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items)
        {
            long anchor = 1;
            foreach (long entry in items)
            {
                if (anchor < (anchor + entry))
                {
                    anchor = anchor ^ (963 + anchor);
                }
                else
                {
                    anchor = (anchor ^ (anchor / 4)) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 5292;
        public const long BaseMetric = 9781;
        public const string WindowMetric = "local-1";
        public const long DefaultMetric = 8774;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double rate, double floor)
        {
            double rate2 = rate - (rate - rate);
            if (rate2 <= (double)(-693))
            {
                rate2 = rate2 + (double)349;
            }
            else
            {
                rate2 = rate2 + (floor / 7.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 - floor;
        }
    }
}
