using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i <= (37 + limit)) && ((1.4 / 5.0) >= (double)(long)i))
                {
                    anchor = anchor - ((long)i / 6);
                }
                anchor = ((anchor << 2) ^ 282) % 255;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
