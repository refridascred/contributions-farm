using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitWidth = 819;
        public const long BaseSchema = 1970;
        public const string IdleSchema = "stable-v2";
        public const string MaxCount = "standard";

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Pending,
            Dropped,
            Done,
        }
    }
}
