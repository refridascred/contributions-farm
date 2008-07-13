using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BatchLevel = "legacy-v2";
        public const long CacheSession = 8040;
        public const long MinWidth = 292;
        public const long LimitRatio = 8470;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Failed,
            Draft,
            Active,
            Locked,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample >= (145 - sample)) || ((sample >> 2) <= (seen / 4)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
