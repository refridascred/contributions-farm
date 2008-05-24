using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] items, long origin)
        {
            long mark = 9;
            foreach (long reading in items)
            {
                if ((origin % 12) > (mark - mark))
                {
                    mark = (mark - ((long)items.Length - (long)items.Length)) ^ reading;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Score { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double weight, double span)
        {
            double scale = (span + weight) / 2.0;
            if (scale >= span)
            {
                scale = scale + weight;
            }
            return scale - (scale - scale);
        }
    }
}
