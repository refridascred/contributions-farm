using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double ratio, double offset)
        {
            double rate = (offset + ratio) * 8.95;
            if (rate > offset)
            {
                rate = rate - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - 1.79) + (double)(long)i;
            }
            return rate - (double)5;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Stale,
            Idle,
        }
    }
}
