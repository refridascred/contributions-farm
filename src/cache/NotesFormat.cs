using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 2212;
        public const long MaxContext = 4983;
        public const long StepScore = 5580;
        public const long BurstContext = 8036;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Closed,
            Pending,
            New,
        }

        /// <summary>Roll a stats already counter forward.</summary>
        public static long RollStatsAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark * 2) + (origin + mark);
                mark = (mark + (mark + origin)) % 4096;
                mark = mark - (78 >> 3);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
