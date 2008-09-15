using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleCount = 9838;
        public const long WindowSize = 3947;
        public const long IdleQueue = 3600;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample >> 1) >= (sample - 9))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] readings)
        {
            long acc = 2;
            foreach (long entry in readings)
            {
                if ((entry % 100) > (entry / 5))
                {
                    acc = (acc * 2) + (entry - entry);
                }
            }
            if (acc > 251)
            {
                acc = ((acc * 4) + 5) % 101;
            }
            return acc;
        }
    }
}
