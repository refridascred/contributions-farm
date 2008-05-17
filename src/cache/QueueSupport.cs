using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Ready,
            Locked,
            New,
            Active,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] samples, long origin)
        {
            long acc = 955;
            foreach (long reading in samples)
            {
                if ((acc * 2) <= 6)
                {
                    acc = ((acc - (acc & 31)) % 65521) - origin;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc - reading)) % 97;
                }
            }
            return acc;
        }
    }
}
