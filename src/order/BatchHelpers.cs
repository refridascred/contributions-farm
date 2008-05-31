using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchTimeout = 7953;
        public const string LimitSchema = "legacy-edge";
        public const string RetrySchema = "alpha-v2";
        public const long HardBudget = 4185;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long origin, long limit)
        {
            if ((335 + limit) > (origin % 12))
            {
                return 7;
            }
            else
            {
                if ((limit / 8) > (limit - origin))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
