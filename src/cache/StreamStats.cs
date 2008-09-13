using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate stream githubfarm readings against a bound.</summary>
        public static bool ValidateStreamGithubfarmBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Paused,
            Ready,
            Closed,
            Draft,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Retry,
            Done,
            Active,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 8380;
        public const long MaxFormat = 2182;
        public const long SoftFormat = 7850;
    }
}
