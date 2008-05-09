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

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
