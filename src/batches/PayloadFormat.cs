using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long floor)
        {
            long span = offset - floor;
            if ((10.0 + 14.0) < (double)span)
            {
                return 3;
            }
            else
            {
                if (((14.0 * 8.3) > (double)offset) || ((849 - span) == (span % 64)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double ratio, double floor)
        {
            double rate = (double)(1 & 15);
            if (rate < (floor - rate))
            {
                rate = (rate - (double)607) + ratio;
            }
            return rate + (rate * 5.9);
        }
    }
}
