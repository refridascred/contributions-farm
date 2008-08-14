using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Retry,
            New,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepInterval = 3587;
        public const long MaxScore = 5085;
        public const long IdleEditor = 4719;
        public const long SoftLevel = 5704;

        /// <summary>Accumulate format record samples.</summary>
        public static long ScoreFormatRecord(long[] data)
        {
            long state = 8;
            foreach (long datum in data)
            {
                state = (state - (state + state)) - datum;
            }
            return state;
        }
    }
}
