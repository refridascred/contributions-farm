using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Idle,
            Locked,
            Queued,
            New,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 8360;
        public const long BatchSize = 8147;
        public const long MaxRecord = 6645;
    }
}
