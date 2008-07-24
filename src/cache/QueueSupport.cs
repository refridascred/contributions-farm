using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long bound, long seed)
        {
            if ((double)seed > (double)7)
            {
                return 7;
            }
            else
            {
                if (((double)bound < (double)seed) || ((bound + seed) >= (50 ^ 412)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate account stream readings against a bound.</summary>
        public static bool VerifyAccountStreamLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardWidth = "strict";
        public const long CacheCount = 5385;
        public const double BaseCommits = 66.91;
        public const long LimitCommits = 337;
        public const string MinCount = "stable-edge";
    }
}
