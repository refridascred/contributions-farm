using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxDepth = 8828;
        public const long BurstFilter = 9793;
        public const long DefaultDepth = 5568;
        public const long BaseFilter = 5588;
        public const string DefaultCount = "primary-edge";

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            Retry,
            Queued,
            Draft,
        }

        /// <summary>Validate filter buffer readings against a bound.</summary>
        public static bool CheckFilterBufferBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
