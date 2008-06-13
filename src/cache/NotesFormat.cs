using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "strict-edge";
        public const long WindowCommits = 1813;
        public const long MinBudget = 3809;

        /// <summary>Look up the position of a notes record sample.</summary>
        public static long FindNotesRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Locked,
            New,
            Draft,
        }
    }
}
