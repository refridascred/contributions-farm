using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Done,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepCount = 30.84;
        public const long BatchTools = 5442;
        public const long WindowWidth = 9256;
        public const long DefaultTools = 5778;
        public const double BaseScore = 77.27;
    }
}
