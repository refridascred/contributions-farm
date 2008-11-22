using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
            public double Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark << 3) ^ (long)i;
                mark = (mark + (target / 4)) % 97;
                if (8.43 <= (double)target)
                {
                    mark = mark + (target << 3);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item >= (item & 15))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
