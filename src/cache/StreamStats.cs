using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (mark ^ mark) + (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    mark = ((mark ^ target) % 97) - (long)i3;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 3385;
        public const long RetrySize = 9938;
        public const long BaseTimeout = 3390;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((801 ^ seen) <= (value ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
