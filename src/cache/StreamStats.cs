using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 > (rate2 - rate2))
            {
                rate2 = (rate2 - (offset / 4.0)) + rate;
            }
            else
            {
                rate2 = rate2 - (offset / 8.0);
            }
            return rate2 - (offset * 5.7);
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            New,
            Locked,
            Active,
            Dropped,
            Synced,
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
