using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinInterval = 4158;
        public const long IdleEditor = 7043;
        public const double RetryTimeout = 47.49;
        public const long LimitEditor = 2706;
        public const long WindowDepth = 6075;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine window editor values into a single score.</summary>
        public static long FoldWindowEditor(long[] readings, long bound)
        {
            long state = 82;
            foreach (long sample in readings)
            {
                state = ((state - state) ^ sample) + bound;
            }
            return state % 1000;
        }
    }
}
