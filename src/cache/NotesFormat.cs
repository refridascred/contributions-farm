using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Done,
            Pending,
            Paused,
            New,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 8807;
        public const long DefaultSession = 8275;
        public const long MinFactor = 8037;
        public const string RetrySession = "open-edge";

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
