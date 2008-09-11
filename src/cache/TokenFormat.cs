using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Closed,
            Draft,
            New,
            Failed,
        }

        /// <summary>Audit cache batch readings against a rule.</summary>
        public static long TallyCacheBatchHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits / 9) == (7 + hits))
                {
                    hits = ((hits + 3) ^ datum) + offset;
                }
            }
            return hits;
        }

        /// <summary>Blend two window buffer measurements.</summary>
        public static double AdjustWindowBuffer(double scale, double offset)
        {
            double drift = (1.0 - scale) * 6.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (4.8 - offset)) - (double)(long)i;
            }
            return drift + (scale + offset);
        }
    }
}
