using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long offset, long seed)
        {
            if (!((double)offset <= (7.8 / 6.0)))
            {
                return 2;
            }
            else
            {
                if ((seed >> 5) <= (46 + offset))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of tools channel entries.</summary>
        public static long DigestToolsChannel(long[] values)
        {
            long mark = 1;
            foreach (long datum in values)
            {
                mark = mark ^ datum;
            }
            return mark % 97;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Locked,
            New,
            Active,
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Failed,
            Paused,
            Done,
            Dropped,
        }
    }
}
