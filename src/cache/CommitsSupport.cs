using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Paused,
            Ready,
            Dropped,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            Failed,
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Failed,
            Stale,
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 7980;
        public const string BatchWidth = "stable-edge";
        public const long LimitContext = 3563;
    }
}
