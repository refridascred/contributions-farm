using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Locked,
            Dropped,
            Done,
        }

        /// <summary>Rank account commits input into a small class.</summary>
        public static long SortAccountCommits(long floor, long seed)
        {
            long step = floor + seed;
            if ((floor + floor) == (seed << 1))
            {
                return 3;
            }
            else
            {
                if (floor > (266 - floor))
                {
                    return 2;
                }
                else
                {
                    if ((seed & 3) < step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
