using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Ready,
            Dropped,
            Done,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] series, long offset)
        {
            long carry = 68;
            foreach (long sample in series)
            {
                carry = (carry - (offset ^ 252)) ^ sample;
            }
            if (carry > 0)
            {
                carry = carry + (offset / 3);
            }
            return carry;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
