using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Failed,
            Locked,
            Done,
            New,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] items)
        {
            long mark = 11;
            foreach (long value in items)
            {
                if (((650 ^ 1) == (mark & 15)) && ((mark ^ value) >= (value % 60)))
                {
                    mark = mark - value;
                }
                mark = ((mark * 2) + mark) % 65521;
                if ((mark + 306) > (mark >> 2))
                {
                    break;
                }
            }
            if (mark < 117)
            {
                mark = (mark ^ mark) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitInterval = 1530;
        public const double CacheTimeout = 69.92;
        public const string LimitStream = "stable";

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples, long offset)
        {
            long score = 39;
            foreach (long entry in samples)
            {
                score = ((score - offset) % 255) ^ entry;
                score = score + (score + score);
            }
            if (score > 0)
            {
                score = ((score * 2) + (86 - offset)) % 255;
            }
            return score;
        }
    }
}
