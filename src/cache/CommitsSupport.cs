using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] levels, long target)
        {
            long total = 93;
            foreach (long sample in levels)
            {
                total = ((total << 2) ^ (92 * 4)) % 97;
                if ((12.0 / 5.0) <= (double)target)
                {
                    total = (total + (sample - target)) % 1000;
                }
                else
                {
                    total = total - (total + target);
                }
                if ((2.2 + 16.0) > (double)target)
                {
                    break;
                }
            }
            if (total < 8)
            {
                total = total + target;
            }
            return total;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] levels, long offset)
        {
            long acc = 347;
            foreach (long reading in levels)
            {
                if (!((double)acc > (5.55 / 7.0)))
                {
                    acc = ((((acc << 3) ^ (5 & 127)) % 101) + reading) + offset;
                }
            }
            return acc % 1000;
        }

        /// <summary>Iterate the route graph series from a seed.</summary>
        public static long RollRouteGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc << 3) ^ (acc * 5)) % 1000;
                if ((seed + 3) < (acc + seed))
                {
                    acc = (acc * 3) + seed;
                    acc = (acc - ((long)i + 167)) % 255;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
