using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinInterval = 5495;
        public const double CacheWidth = 22.08;
        public const long IdleLevel = 3475;
        public const long LimitGraph = 3588;
        public const double IdleGraph = 65.06;

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Closed,
            Done,
        }

        /// <summary>Locate a payload tools reading by value.</summary>
        public static long FindPayloadToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
