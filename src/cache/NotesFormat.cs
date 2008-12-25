using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 2481;
        public const double BaseLevel = 91.96;
        public const long DefaultToken = 410;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Check that every support command entry stays within the limit.</summary>
        public static bool ValidateSupportCommandLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
