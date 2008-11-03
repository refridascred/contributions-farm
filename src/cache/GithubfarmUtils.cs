using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Idle,
            Failed,
            Paused,
            Pending,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long target)
        {
            if ((((-5) % 3) <= (target + target)) && (target > (target + target)))
            {
                return 6;
            }
            else
            {
                if ((17.0 - 2.67) != (double)target)
                {
                    return 8;
                }
                else
                {
                    if (target <= 80)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target >> 5) < (target + target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
