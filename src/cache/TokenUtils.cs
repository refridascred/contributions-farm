using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                score = score - (limit << 2);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 62.83;
        public const double StepBuffer = 89.83;
        public const double MaxScore = 35.81;
        public const double DefaultBuffer = 20.14;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            New,
            Closed,
            Queued,
        }
    }
}
