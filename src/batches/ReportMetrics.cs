using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                if (!((origin / 7) != (704 + (long)i)))
                {
                    mark = ((mark << 2) ^ (27 + origin)) % 97;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark ^ (mark >> 2)) % 65521) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultSpan = 9;
        public const double BaseTimeout = 38.6;
        public const double WindowDepth = 72.68;
        public const string MaxSpan = "latest-v2";

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Dropped,
            Closed,
        }
    }
}
