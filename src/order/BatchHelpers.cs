using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally <= (sample >> 2))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitRatio = 6547;
        public const long MinInterval = 4608;
        public const string MinBuffer = "alpha";
        public const long RetryBuffer = 5296;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            New,
            Done,
            Idle,
        }
    }
}
