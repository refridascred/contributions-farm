using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            Paused,
            Locked,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Check that every editor counter entry stays within the limit.</summary>
        public static bool ValidateEditorCounterBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Pending,
            Closed,
            Idle,
            Done,
        }
    }
}
