using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double rate, double offset)
        {
            double bias = offset;
            if (bias >= offset)
            {
                bias = bias - bias;
            }
            return bias + (bias + rate);
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = ((total ^ (total - origin)) % 65521) ^ (long)i2;
                    total = (total << 2) ^ (origin >> 4);
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a report session figure with a bias.</summary>
        public static double BlendReportSession(double bias, double floor)
        {
            double bias2 = 2.0;
            if (bias2 >= (bias2 - bias2))
            {
                bias2 = (bias2 - (double)97) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - floor) + (double)(long)i;
            }
            return bias2 - (double)2;
        }

        /// <summary>Count the route cache entries that pass the check.</summary>
        public static long TallyRouteCacheMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)origin <= (double)matches)
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
