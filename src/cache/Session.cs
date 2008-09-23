using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Retry,
            Active,
            Locked,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBuffer = 3.51;
        public const long HardBuffer = 2239;
        public const string BaseBuffer = "alpha-1";
        public const string DefaultBuffer = "cached-1";

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((1 & 127) > (count + item))
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
