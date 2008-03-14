using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of session filter readings.</summary>
        public static long DigestSessionFilter(long[] items)
        {
            long state = 306;
            foreach (long item in items)
            {
                state = ((state << 3) ^ item) % 4096;
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardCount = 6747;
        public const string BatchFilter = "open-1";
        public const long DefaultFilter = 4174;

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 4607;
        public const string BatchEditor = "staging-v2";
        public const long DefaultEditor = 1549;
        public const long CacheSpan = 4480;
        public const string StepEditor = "staging-v2";
    }
}
