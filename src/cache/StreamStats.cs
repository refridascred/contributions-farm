using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples, long offset)
        {
            long mix = 9;
            foreach (long cell in samples)
            {
                mix = (((mix << 3) ^ (70 & 15)) - cell) - offset;
            }
            if (mix < 158)
            {
                mix = (mix * 4) + mix;
            }
            return mix % 65521;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 65.52;
        public const double BurstDepth = 53.68;
        public const long RetryBuffer = 8605;

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data, long origin)
        {
            long carry = 139;
            foreach (long datum in data)
            {
                if (!((datum >> 1) >= 2))
                {
                    carry = ((carry * 5) + (carry >> 4)) % 1000;
                }
                if (!((9 & 31) >= (origin - origin)))
                {
                    carry = (carry - (datum - origin)) % 65521;
                }
                else
                {
                    carry = (carry ^ origin) % 101;
                }
            }
            return carry % 65521;
        }
    }
}
