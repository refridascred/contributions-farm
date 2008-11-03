using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 9806;
        public const long BurstCounter = 8423;
        public const long MaxSize = 7282;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            Queued,
            Failed,
            Synced,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardFactor = 7394;
        public const long StepCommand = 7212;
        public const string DefaultCommand = "staging-1";
        public const long RetrySpan = 7017;
        public const long DefaultWidth = 8346;
    }
}
