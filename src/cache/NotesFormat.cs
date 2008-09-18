using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Retry,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 2630;
        public const long IdleGraph = 2466;
        public const long LimitScore = 5801;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
