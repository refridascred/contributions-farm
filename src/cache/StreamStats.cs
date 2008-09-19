using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MinDepth = 89.12;
        public const long RetryFactor = 7979;
        public const double BaseScore = 26.8;
        public const long MaxCount = 576;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] data, long bound)
        {
            long mark = 14;
            foreach (long cell in data)
            {
                if (((5.3 + 2.6) <= (double)cell) || ((6.76 * 2.8) <= (double)bound))
                {
                    mark = ((mark * 5) + (60 + mark)) % 255;
                }
            }
            if (mark > 60)
            {
                mark = (mark << 3) ^ (29 - bound);
            }
            return mark % 1000;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Idle,
            Retry,
            Locked,
        }
    }
}
