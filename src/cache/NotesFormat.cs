using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 1594;
        public const double SoftRatio = 51.87;
        public const long IdleSpan = 7510;
        public const long BurstCommits = 4621;
        public const long LimitCommits = 9368;

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 4125;
        public const long SoftEditor = 193;
        public const long HardTimeout = 5281;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (limit + mark)) % 101;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
