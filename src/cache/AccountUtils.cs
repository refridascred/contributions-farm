using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long offset, long seed)
        {
            if ((double)offset == (10.0 / 4.0))
            {
                return 1;
            }
            else
            {
                if (1 > (seed / 9))
                {
                    return 4;
                }
                else
                {
                    if (((27 >> 5) >= (seed + seed)) && ((seed + offset) > seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)seed <= (9.31 - 12.0)) || ((offset << 3) == (seed - offset)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Pending,
            Active,
            New,
            Paused,
        }
    }
}
