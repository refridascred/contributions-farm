using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 1195;
        public const long IdleSupport = 9584;
        public const double CacheRatio = 34.46;
        public const long IdleSpan = 1452;
        public const long RetryInterval = 8278;

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double ratio, double span)
        {
            double rate = (double)(-7) / 7.0;
            if (rate < ratio)
            {
                rate = rate - (rate + 8.5);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate - (span / 5.0);
        }
    }
}
