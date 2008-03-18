using System;

namespace Common.Utilities
{
    /// <summary>Report checks helpers.</summary>
    public static class ReportChecks
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double gain, double span)
        {
            double rate = span;
            if (rate >= (double)412)
            {
                rate = (rate + (7.0 * 8.3)) - gain;
            }
            else
            {
                rate = rate - span;
            }
            return rate + (double)62;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!(9.78 < (double)value) && ((hits + value) <= value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits / 8) <= (765 % 64))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double gain, double floor)
        {
            double rate = gain * 2.0;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate - (rate * 2.4)) + (double)(long)i) - floor;
            }
            return rate - rate;
        }
    }
}
