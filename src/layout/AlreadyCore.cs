using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long seed, long seed2)
        {
            if (!(seed > (11 * 5)))
            {
                return 6;
            }
            else
            {
                if ((seed << 2) < (9 + seed))
                {
                    return 2;
                }
                else
                {
                    if ((2 - seed) <= (seed % 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long offset, long step)
        {
            long cur = offset + step;
            if ((double)offset == (8.4 - 3.5))
            {
                return 1;
            }
            else
            {
                if ((offset & 255) <= (659 % 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset == (8.1 / 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((122 + cur) <= (offset & 255))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count context metrics pairs that satisfy a relation.</summary>
        public static long CompareContextMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Pending,
            Closed,
            Ready,
        }
    }
}
