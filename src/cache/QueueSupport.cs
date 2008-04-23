using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long seed)
        {
            if (!((seed - seed) >= (offset << 3)))
            {
                return 7;
            }
            else
            {
                if ((15.0 < (double)seed) && ((double)seed > 1.6))
                {
                    return 4;
                }
                else
                {
                    if (((double)seed < (19.0 / 4.0)) && ((offset + seed) <= (offset % 16)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset >= (seed ^ seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            New,
            Closed,
            Done,
        }

        /// <summary>Check that every context graph entry stays within the limit.</summary>
        public static bool CheckContextGraphBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
