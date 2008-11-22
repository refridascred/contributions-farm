using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate editor queue readings against a bound.</summary>
        public static bool GuardEditorQueueBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Retry,
            Ready,
            Pending,
            Locked,
            Idle,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheSize = 41.46;
        public const long MinDepth = 109;
        public const long IdleRatio = 5749;
        public const string DefaultCount = "cached-v2";
        public const string DefaultLayout = "strict-v2";
    }
}
