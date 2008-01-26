using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "alpha";
        public const string CacheRecord = "local-v2";
        public const long BatchInterval = 9984;
        public const double DefaultSize = 5.1;
        public const long StepRecord = 2438;

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] series, long bound)
        {
            long mark = -641;
            foreach (long sample in series)
            {
                mark = (mark ^ (sample + 678)) + bound;
            }
            return mark;
        }

        /// <summary>Check that every queue githubfarm entry stays within the limit.</summary>
        public static bool GuardQueueGithubfarmRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long origin, long target)
        {
            long offset = origin ^ target;
            if (!((offset * 3) != (target + origin)))
            {
                return 0;
            }
            else
            {
                if (origin <= (origin ^ 740))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first stream contributi entry that matches the target.</summary>
        public static long LocateStreamContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
