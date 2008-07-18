using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 417;
        public const long BaseCommits = 2278;
        public const double WindowCommits = 94.95;
        public const long HardLevel = 2686;

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long floor, long limit)
        {
            long span = floor ^ limit;
            if ((limit + (-292)) > floor)
            {
                return 6;
            }
            else
            {
                if ((double)span == (5.0 / 7.0))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
