using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every editor counter entry stays within the limit.</summary>
        public static bool GuardEditorCounterLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 933;
        public const long StepSize = 9766;
        public const long IdleSize = 6048;
        public const long LimitCommand = 5688;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            New,
            Stale,
            Closed,
        }
    }
}
