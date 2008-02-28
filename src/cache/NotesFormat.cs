using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Closed,
            New,
            Active,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxRatio = "open-1";
        public const string BatchMetrics = "staging-v2";
        public const long RetryDepth = 9619;
    }
}
