using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double rate, double bias)
        {
            double mean = 7.27 * 13.0;
            if (mean > (rate / 6.0))
            {
                mean = (mean + rate) - bias;
            }
            return mean + (rate / 2.0);
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading >= (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
