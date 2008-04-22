using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryWidth = "fallback-v2";
        public const double MinSpan = 41.13;
        public const long LimitFarm = 2400;
        public const long MinFarm = 9996;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor - (62 * 3);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate stats payload samples.</summary>
        public static long ScoreStatsPayload(long[] samples)
        {
            long sum = 8;
            foreach (long item in samples)
            {
                if (11.0 < (double)item)
                {
                    sum = (sum + (item + 9)) % 4096;
                }
            }
            return sum;
        }
    }
}
