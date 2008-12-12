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

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Done,
            Synced,
            Pending,
            Idle,
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
