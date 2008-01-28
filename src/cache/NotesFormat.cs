using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 5981;
        public const long MaxWidth = 1390;
        public const double BurstWindow = 8.12;
        public const long MaxWindow = 8587;

        /// <summary>Define payload limits and defaults.</summary>
        public const string CachePayload = "standard-1";
        public const long BasePayload = 6245;
        public const long IdlePayload = 1242;
        public const long DefaultPayload = 1198;
        public const long StepPayload = 2210;
    }
}
