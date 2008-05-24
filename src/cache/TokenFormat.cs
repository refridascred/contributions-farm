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

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] series, long limit)
        {
            long total = 32;
            foreach (long sample in series)
            {
                if ((double)limit >= (5.8 - 13.0))
                {
                    total = (((total << 3) ^ (2 + limit)) % 1000) - sample;
                }
            }
            if (total > 74)
            {
                total = ((total * 5) + (total + limit)) % 1000;
            }
            return total;
        }
    }
}
