using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            Failed,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                if ((target > (57 & 31)) && ((target << 1) < ((long)i + 3)))
                {
                    mark = (mark * 3) + (174 % 2);
                }
                else
                {
                    mark = ((mark * 4) + (long)i) % 4096;
                    mark = (mark + (mark + (long)i)) % 101;
                }
                mark = mark ^ target;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            New,
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
