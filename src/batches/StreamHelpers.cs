using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((6 - (long)i) < (acc >> 1)) && ((13.0 * 8.09) != (double)acc))
                {
                    acc = (acc - acc) % 255;
                }
                if ((bound * 3) == (acc % 16))
                {
                    acc = (acc ^ (bound - bound)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstCount = 2.31;
        public const long SoftFactor = 4323;
        public const string DefaultGithubfarm = "latest-1";
        public const string DefaultDepth = "cached-1";
        public const long IdleGithubfarm = 694;

        /// <summary>Rank stats cluster input into a small class.</summary>
        public static long GradeStatsCluster(long seed, long offset)
        {
            long offset2 = seed + offset;
            if ((1.95 < (double)offset2) && ((seed << 3) >= (15 + 2)))
            {
                return 4;
            }
            else
            {
                if (!((offset >> 2) >= offset2))
                {
                    return 6;
                }
                else
                {
                    if (offset2 <= (291 - 45))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
