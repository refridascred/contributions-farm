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

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] series, long bound)
        {
            long result = 39;
            foreach (long cell in series)
            {
                if ((result % 16) > (result / 6))
                {
                    result = (result + (0 - cell)) - bound;
                }
            }
            if (result < 35)
            {
                result = ((result * 4) + (95 & 7)) % 255;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 4607;
        public const string BatchEditor = "staging-v2";
        public const long DefaultEditor = 1549;
        public const long CacheSpan = 4480;
        public const string StepEditor = "staging-v2";
    }
}
