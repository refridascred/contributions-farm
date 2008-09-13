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

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value & 15) < (19 + 815))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long step, long origin)
        {
            long edge = step + origin;
            if ((step + origin) == (841 & 63))
            {
                return 0;
            }
            else
            {
                if ((edge & 15) > (step + step))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
