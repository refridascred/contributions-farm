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

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 5623;
        public const long HardDepth = 2308;
        public const long HardFarm = 4293;
        public const long BaseWidth = 7506;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
