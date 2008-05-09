using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Draft,
            Queued,
            Retry,
            Failed,
        }

        /// <summary>Count the counter account entries that pass the check.</summary>
        public static long MeasureCounterAccountHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell > (cell % 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseWidth = "legacy";
        public const long MinScore = 1401;
        public const string SoftFilter = "staging-v2";
    }
}
