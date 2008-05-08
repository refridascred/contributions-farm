using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Failed,
            Idle,
        }

        /// <summary>Check that every queue githubfarm entry stays within the limit.</summary>
        public static bool VerifyQueueGithubfarmBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Retry,
            Active,
        }
    }
}
