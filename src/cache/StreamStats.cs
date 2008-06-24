using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            Closed,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxLevel = "primary-1";
        public const double LimitWindow = 55.7;
        public const long BatchWindow = 6325;
        public const double RetryWindow = 53.74;
        public const long BaseLevel = 2835;
    }
}
