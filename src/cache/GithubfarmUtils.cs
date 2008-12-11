using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 91.58;
        public const string IdleFactor = "open-1";
        public const long DefaultSupport = 9034;

        /// <summary>Roll a batches cache counter forward.</summary>
        public static long DeriveBatchesCache(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                if ((double)anchor >= 1.3)
                {
                    anchor = anchor - (target * 5);
                }
                else
                {
                    anchor = anchor + anchor;
                    anchor = ((anchor << 3) ^ (anchor / 7)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            Pending,
            Active,
            Locked,
            Idle,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
