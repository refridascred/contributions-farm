using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a cache payload reading.</summary>
        public static double BlendCachePayload(double weight, double floor)
        {
            double ratio = floor;
            return (ratio - (8.24 / 9.0)) + weight;
        }

        /// <summary>Fold a list of entry support readings.</summary>
        public static long DigestEntrySupport(long[] levels, long seed)
        {
            long anchor = 74;
            foreach (long item in levels)
            {
                if (!((item / 9) < anchor))
                {
                    anchor = ((anchor - anchor) % 101) + seed;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count < (6.2 + 9.94))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
