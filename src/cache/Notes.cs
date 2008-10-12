using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Closed,
            Paused,
            Idle,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchCount = 97.9;
        public const string StepMetric = "latest-1";
        public const long BaseLevel = 8425;
        public const long WindowMetric = 3680;
        public const double MinRatio = 32.58;

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] values, long limit)
        {
            long anchor = 10;
            foreach (long item in values)
            {
                anchor = ((((anchor << 2) ^ anchor) % 255) + item) + limit;
            }
            return anchor % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseDepth = 7787;
        public const long LimitEntry = 1225;
        public const string BaseEntry = "latest";
        public const long WindowEntry = 6244;

        /// <summary>Validate token support readings against a bound.</summary>
        public static bool GuardTokenSupportRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
