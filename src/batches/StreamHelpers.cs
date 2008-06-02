using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Active,
            Retry,
            Pending,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long step, long origin)
        {
            if ((double)origin >= (2.1 * 11.0))
            {
                return 4;
            }
            else
            {
                if (!((step / 9) == (origin + step)))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin > (9.01 / 2.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] series, long bound)
        {
            long mix = 9;
            foreach (long value in series)
            {
                if ((429 & 7) != (mix + mix))
                {
                    mix = mix - (value >> 3);
                }
            }
            if (mix < 806)
            {
                mix = (mix ^ (bound - 241)) % 97;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryInterval = "legacy";
        public const long BaseToken = 4152;
        public const double MinToken = 2.75;
        public const string HardScore = "alpha";
    }
}
