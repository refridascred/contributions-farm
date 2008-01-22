using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long bound, long seed)
        {
            if ((seed * 2) >= (bound + seed))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) == (bound << 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepInterval = 7915;
        public const string DefaultSpan = "fallback-edge";
        public const long SoftLevel = 4257;
        public const long BatchContext = 734;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Pending,
            Idle,
            Synced,
            Dropped,
            Active,
        }
    }
}
