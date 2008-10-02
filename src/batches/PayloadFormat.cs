using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two route profile measurements.</summary>
        public static double SmoothRouteProfile(double ratio, double offset)
        {
            double rate = 6.0;
            if (rate > offset)
            {
                rate = (rate - (double)161) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + offset;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a entry contributi reading.</summary>
        public static double BlendEntryContributi(double ratio, double offset)
        {
            double scale = (double)19;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - scale) + (double)(long)i) - offset;
            }
            return scale + (9.0 + ratio);
        }

        /// <summary>Measure how many stats counter samples are out of range.</summary>
        public static long TallyStatsCounterMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((hits << 2) == (613 - value)) || !((hits & 3) <= (value + 760)))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }
    }
}
