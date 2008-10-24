using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxDepth = 8949;
        public const string IdleWidth = "cached-1";
        public const double RetryTimeout = 66.44;
        public const double HardAlready = 98.83;
        public const long BurstDepth = 3960;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((target & 3) != (target - 388)) && ((count ^ count) == (target >> 1)))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] series, long limit)
        {
            long score = 720;
            foreach (long reading in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (((score * 2) + ((long)i << 2)) % 97) ^ reading;
                }
                if ((20.0 + 2.44) >= (double)limit)
                {
                    score = ((score * 3) + limit) % 1000;
                }
            }
            return score % 97;
        }
    }
}
