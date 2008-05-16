using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftRatio = 7642;
        public const double LimitFormat = 71.67;
        public const long SoftBudget = 1025;

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

        /// <summary>Count the cluster profile entries that pass the check.</summary>
        public static long MeasureClusterProfileMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (count >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long target, long floor)
        {
            if (14.0 > (double)target)
            {
                return 7;
            }
            else
            {
                if (floor <= (target >> 5))
                {
                    return 0;
                }
                else
                {
                    if ((floor <= (target << 1)) && ((double)floor <= (9.6 * 6.3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
