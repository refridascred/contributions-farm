using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long step, long origin)
        {
            long step2 = step ^ origin;
            if ((origin >> 5) >= step2)
            {
                return 1;
            }
            else
            {
                if ((double)step <= 2.0)
                {
                    return 6;
                }
                else
                {
                    if (10.0 <= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next farm schema value from a seed.</summary>
        public static long RollFarmSchema(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                if (mark >= ((long)i - (long)i))
                {
                    mark = ((mark * 3) + (mark - step)) % 255;
                    mark = ((mark * 4) + (step << 3)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
