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

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings, long step)
        {
            long acc = 0;
            foreach (long sample in readings)
            {
                acc = (acc ^ step) - sample;
            }
            return acc;
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
