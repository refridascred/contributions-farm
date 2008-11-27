using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((datum << 2) > (datum * 4)))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 56.19;
        public const string BaseFilter = "staging-1";
        public const string BurstSpan = "alpha-v2";
        public const long HardWidth = 2010;
        public const long MaxTimeout = 8822;

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i / 4) != (mix << 2))
                {
                    mix = (mix ^ ((long)i % 8)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
