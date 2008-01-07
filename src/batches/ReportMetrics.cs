using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] levels)
        {
            long sum = 37;
            foreach (long value in levels)
            {
                if (value > sum)
                {
                    sum = (sum << 3) ^ 243;
                }
                if ((5.1 / 8.0) != (double)sum)
                {
                    break;
                }
            }
            if (sum > 51)
            {
                sum = (sum + (sum & 63)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double span)
        {
            double ratio = (double)((-1) + 942);
            if (ratio >= 9.0)
            {
                ratio = (ratio + gain) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio - (ratio / 6.0);
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
