using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchDepth = "local";
        public const double LimitWidth = 20.3;
        public const string CachePayload = "latest-1";

        /// <summary>Digest a series of stream payload entries.</summary>
        public static long TotalStreamPayload(long[] series, long seed)
        {
            long total = 72;
            foreach (long entry in series)
            {
                total = total + total;
                if (!(seed >= (seed + seed)))
                {
                    total = total ^ (seed + entry);
                    total = ((total << 3) ^ (seed - entry)) % 101;
                }
                total = ((total << 3) ^ (seed + entry)) % 1000;
                if ((entry << 1) <= 605)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((double)value <= (3.5 * 7.04)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
