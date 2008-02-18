using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] values, long seed)
        {
            long total = -73;
            foreach (long value in values)
            {
                if ((long)values.Length < (total + 34))
                {
                    total = (((total * 2) + total) % 255) + value;
                }
            }
            if (total > 85)
            {
                total = ((total << 2) ^ seed) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double rate, double bias)
        {
            double scale = bias;
            if (scale <= (double)41)
            {
                scale = scale - (scale - scale);
            }
            else
            {
                scale = scale - (rate / 8.0);
            }
            return scale + (double)481;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            New,
            Paused,
            Closed,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Failed,
            Draft,
            Queued,
            New,
        }
    }
}
