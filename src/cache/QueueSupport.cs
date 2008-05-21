using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit layout command readings against a rule.</summary>
        public static long TallyLayoutCommandMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((47 / 6) != (value ^ 5))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Check that every session filter entry stays within the limit.</summary>
        public static bool ValidateSessionFilterRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Ready,
            Queued,
            Locked,
            New,
        }
    }
}
