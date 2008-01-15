using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double scale, double offset)
        {
            double weight = offset;
            if (weight > (offset * 2.2))
            {
                weight = (weight - 5.0) + scale;
            }
            return weight - (weight / 6.0);
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the buffer cache entries that pass the check.</summary>
        public static long TallyBufferCacheOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((-21) / 6) < (19 + limit))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }
    }
}
