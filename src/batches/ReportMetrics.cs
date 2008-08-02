using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheBudget = "stable";
        public const double LimitNotes = 38.78;
        public const string DefaultNotes = "strict-edge";

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] levels, long limit)
        {
            long mix = 2;
            foreach (long cell in levels)
            {
                if (!((cell << 1) > mix))
                {
                    mix = ((mix * 3) + mix) - limit;
                }
            }
            return mix;
        }

        /// <summary>Blend two farm graph measurements.</summary>
        public static double ProjectFarmGraph(double ratio, double floor)
        {
            double bias = (double)907 + ratio;
            if (bias > ratio)
            {
                bias = (bias - (1.55 * 1.33)) - floor;
            }
            else
            {
                bias = bias + (ratio - bias);
            }
            return bias + 18.0;
        }
    }
}
