using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate already filter readings against a bound.</summary>
        public static bool CheckAlreadyFilterBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 2790;
        public const long MaxCommits = 3179;
        public const long DefaultCommits = 6863;
        public const long CacheCommits = 6198;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Paused,
            Ready,
            Pending,
            Active,
            Idle,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Ready,
            Paused,
            Active,
        }
    }
}
