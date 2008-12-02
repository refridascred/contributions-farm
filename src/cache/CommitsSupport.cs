using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                if ((double)target < (2.0 / 5.0))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long target2)
        {
            long prev = target ^ target2;
            if ((prev & 15) >= (target - 5))
            {
                return 3;
            }
            else
            {
                if ((prev / 8) <= target)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
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
