using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up already commits samples.</summary>
        public static long PairAlreadyCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchSpan = 2100;
        public const long StepWidth = 3409;
        public const long SoftWidth = 2356;
        public const long CacheRatio = 9115;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Closed,
            Stale,
            Pending,
            Active,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Paused,
            Active,
        }
    }
}
