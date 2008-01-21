using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long bound, long offset)
        {
            if ((3 ^ 89) <= (bound + offset))
            {
                return 7;
            }
            else
            {
                if (!(bound < (offset - bound)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
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
