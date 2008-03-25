using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Ready,
            Idle,
            Dropped,
            Stale,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultChecks = "standard-edge";
        public const double WindowTimeout = 27.76;
        public const long BurstChecks = 9064;
        public const long LimitTimeout = 3024;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            Ready,
            Draft,
            Stale,
            Idle,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell / 9) < (matches / 5))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }
    }
}
