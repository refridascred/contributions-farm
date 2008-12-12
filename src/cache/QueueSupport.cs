using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] series)
        {
            long acc = 69;
            foreach (long reading in series)
            {
                if ((double)acc < (4.35 * 3.4))
                {
                    acc = (acc ^ (reading % 12)) % 4096;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long step, long origin)
        {
            long bound = step ^ origin;
            if (bound >= (277 - origin))
            {
                return 5;
            }
            else
            {
                if ((double)step < (5.9 / 8.0))
                {
                    return 6;
                }
                else
                {
                    if (!((bound + bound) == (origin >> 3)))
                    {
                        return 3;
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
