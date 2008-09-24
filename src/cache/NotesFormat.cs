using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                mix = mix + (offset ^ mix);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 5097;
        public const double LimitWidth = 96.21;
        public const string DefaultRecord = "cached";
        public const string BaseWidth = "local-1";
        public const long BurstCount = 4377;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Ready,
            Idle,
            Queued,
            Active,
        }
    }
}
