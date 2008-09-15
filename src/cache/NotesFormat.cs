using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 7356;
        public const double RetrySchema = 90.99;
        public const double MaxSchema = 33.1;

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitTimeout = 7919;
        public const string DefaultRoute = "standard-v2";
        public const double IdleSpan = 60.95;
        public const long BaseRoute = 3457;
        public const string MinFactor = "cached-1";
    }
}
