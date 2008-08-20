using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 8243;
        public const string StepOrder = "staging";
        public const long BaseOrder = 8884;
        public const string MaxBudget = "alpha-1";
        public const long IdleRatio = 525;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the route farm entries that pass the check.</summary>
        public static long MeasureRouteFarmGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches + matches) >= (entry << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
