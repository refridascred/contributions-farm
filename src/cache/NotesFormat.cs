using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchFactor = 4976;
        public const double LimitDepth = 0.43;
        public const long HardDepth = 8690;
        public const long StepScore = 8046;
        public const long WindowRatio = 8965;
    }
}
