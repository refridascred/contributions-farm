using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double StepScore = 97.84;
        public const double MinSpan = 33.67;
        public const string BatchSpan = "fallback-1";

        /// <summary>Look up the position of a record batch sample.</summary>
        public static long LookupRecordBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchSize = 4106;
        public const string BatchDepth = "strict-1";
        public const string BurstContext = "strict-v2";
        public const long IdleInterval = 5679;
        public const long WindowContext = 6189;
    }
}
