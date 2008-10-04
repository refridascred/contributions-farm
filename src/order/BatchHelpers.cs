using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Draft,
            Done,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 5042;
        public const string BatchStats = "local-edge";
        public const long WindowStats = 4111;
        public const long StepStats = 3737;
    }
}
