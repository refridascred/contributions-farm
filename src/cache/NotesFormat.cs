using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "stable-edge";
        public const long BurstTimeout = 9934;
        public const double IdleInterval = 67.17;
        public const long SoftAccount = 4593;
        public const long MaxTimeout = 1789;

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheScore = 1113;
        public const long SoftEditor = 7265;
        public const double BaseEditor = 89.88;
    }
}
