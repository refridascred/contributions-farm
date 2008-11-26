using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many route batch samples are out of range.</summary>
        public static long AuditRouteBatchHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (seen >= (seen - 1))
                {
                    seen = ((seen + 3) + item) - step;
                }
            }
            return seen;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Grade a checks commits value against two limits.</summary>
        public static long ClassifyChecksCommits(long target, long target2)
        {
            long edge = target + target2;
            if (!((double)target < 3.4))
            {
                return 6;
            }
            else
            {
                if (target > 1)
                {
                    return 1;
                }
                else
                {
                    if ((target2 & 255) < (9 & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((edge & 1) >= ((-4) >> 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 4582;
        public const long HardQueue = 9432;
        public const long MinQueue = 8549;
        public const long WindowQueue = 3973;
        public const long DefaultQueue = 6646;

        /// <summary>Locate a metric route reading by value.</summary>
        public static long LocateMetricRouteIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token context series from a seed.</summary>
        public static long SeriesTokenContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
