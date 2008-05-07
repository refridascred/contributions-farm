using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxInterval = 3297;
        public const long BurstSpan = 3522;
        public const string MinChannel = "fallback-1";
        public const long WindowChannel = 1926;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Active,
            Queued,
            Locked,
            Retry,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
