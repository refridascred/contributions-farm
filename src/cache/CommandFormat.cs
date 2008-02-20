using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen >> 5) > (target - item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxDepth = 763;
        public const long WindowCount = 8321;
        public const long StepCounter = 849;

        /// <summary>Check that every counter tools entry stays within the limit.</summary>
        public static bool CheckCounterToolsLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            New,
            Failed,
            Queued,
            Ready,
        }
    }
}
