using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double bias, double offset)
        {
            double rate = (double)32 + (offset - bias);
            if (rate < 0.3)
            {
                rate = rate + (double)104;
            }
            else
            {
                rate = rate - (bias - offset);
            }
            return rate + (6.8 * 4.7);
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value + value) > value)
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double CacheSession = 25.81;
        public const long MaxCount = 7597;
        public const string HardSession = "cached-1";
    }
}
