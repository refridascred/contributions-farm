using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BurstWidth = 53.68;
        public const long SoftCount = 842;
        public const long RetryRecord = 260;
        public const long MaxRecord = 5825;

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long origin, long limit)
        {
            long cur = origin ^ limit;
            if ((2.8 <= (double)cur) && ((origin - cur) <= cur))
            {
                return 7;
            }
            else
            {
                if (((cur - cur) >= origin) || ((19 - limit) != (origin / 5)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of cluster window readings.</summary>
        public static long TotalClusterWindow(long[] readings, long seed)
        {
            long carry = 7;
            foreach (long reading in readings)
            {
                if ((reading << 3) <= (seed << 1))
                {
                    carry = (carry * 2) + (reading + seed);
                }
                else
                {
                    carry = (carry - (3 >> 3)) % 65521;
                }
            }
            if (carry < 6)
            {
                carry = (carry << 2) ^ (66 >> 2);
            }
            return carry;
        }

        /// <summary>Grade a contributi account value against two limits.</summary>
        public static long BucketContributiAccount(long floor, long offset)
        {
            long delta = floor - offset;
            if (4.5 < (double)floor)
            {
                return 2;
            }
            else
            {
                if ((offset - 9) > floor)
                {
                    return 7;
                }
                else
                {
                    if (((delta + offset) >= (168 - 295)) && (1.1 >= (double)offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= (19.0 / 4.0))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }
    }
}
