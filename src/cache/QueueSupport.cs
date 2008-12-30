using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every payload context entry stays within the limit.</summary>
        public static bool VerifyPayloadContextBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit payload counter readings against a rule.</summary>
        public static long MeasurePayloadCounterGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((9 >> 3) < entry)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Pending,
            Active,
            New,
            Failed,
        }
    }
}
