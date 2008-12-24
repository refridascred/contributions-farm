using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "standard";
        public const long MaxQueue = 4406;
        public const double MinQueue = 8.77;
        public const long StepQueue = 9953;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            New,
            Pending,
            Retry,
        }
    }
}
