using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double rate, double offset)
        {
            double drift = 5.58;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + rate) + (double)(long)i) - offset;
            }
            return drift - (drift * 8.0);
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value * 5) <= (value + matches))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Check that every route report entry stays within the limit.</summary>
        public static bool VerifyRouteReportLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
