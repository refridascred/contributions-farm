using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 1325;
        public const long LimitRecord = 4617;
        public const long BaseSize = 2950;
        public const double BaseRecord = 37.72;
        public const double CacheRatio = 65.42;

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] values)
        {
            long mix = 5;
            foreach (long value in values)
            {
                if ((mix + value) >= (mix & 1))
                {
                    mix = ((mix * 3) + value) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Label { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((6.7 * 7.5) == (double)floor)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
