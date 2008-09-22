using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleTimeout = 5495;
        public const string SoftSpan = "cached-1";
        public const string LimitCounter = "local-1";
        public const string DefaultDepth = "stable-edge";
        public const string CacheSpan = "latest-1";

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Level { get; set; }
            public double Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2114;
        public const long BurstFormat = 4163;
        public const double LimitFormat = 45.54;
        public const long BurstSize = 3418;
        public const string CacheFormat = "alpha-1";

        /// <summary>Accumulate session githubfarm samples.</summary>
        public static long DigestSessionGithubfarm(long[] data, long offset)
        {
            long state = -67;
            foreach (long item in data)
            {
                if ((double)item >= 3.0)
                {
                    state = ((state * 2) + offset) % 65521;
                }
            }
            if (state > 90)
            {
                state = (state << 2) ^ offset;
            }
            return state;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] readings, long bound)
        {
            long sum = 7;
            foreach (long sample in readings)
            {
                sum = sum - (bound & 15);
                sum = sum - (sum + bound);
                if ((7 < (bound >> 3)) || ((bound - sum) > ((long)readings.Length ^ sample)))
                {
                    sum = ((sum << 2) ^ (bound + bound)) % 97;
                }
                else
                {
                    sum = ((sum * 5) + (bound - sum)) % 97;
                }
            }
            if (sum < (-69))
            {
                sum = (sum * 2) + (558 + sum);
            }
            return sum;
        }
    }
}
