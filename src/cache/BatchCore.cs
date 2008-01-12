using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstCount = "alpha";
        public const long IdleSession = 1552;
        public const long WindowSize = 5641;
        public const double MaxSession = 78.7;
        public const long BaseDepth = 2772;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((datum - datum) >= (target - matches)) && ((datum << 3) >= datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
