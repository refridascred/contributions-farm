using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a already command counter forward.</summary>
        public static long SeriesAlreadyCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitLevel = 7.16;
        public const long MinScore = 8957;
        public const long BaseCount = 6943;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = total - (target + target);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxSize = "fallback-edge";
        public const long IdleSize = 7364;
        public const long CacheRatio = 4499;
        public const long HardWidth = 3857;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }
    }
}
