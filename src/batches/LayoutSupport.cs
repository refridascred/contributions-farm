using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many layout format samples are out of range.</summary>
        public static long AuditLayoutFormatHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (1.2 < (double)sample)
                {
                    hits = (hits + 3) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public bool Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)seen <= (3.15 * 15.0))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 2687;
        public const string WindowRatio = "fallback-v2";
        public const double MinChannel = 96.88;

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double gain, double span)
        {
            double weight = gain;
            if (weight <= 2.7)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight - (double)1;
            }
            return weight + (span * 2.6);
        }
    }
}
