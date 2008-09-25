using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long step, long limit)
        {
            long offset = step - limit;
            if (((limit & 31) <= (518 * 4)) || ((254 + limit) >= 8))
            {
                return 2;
            }
            else
            {
                if ((step + step) >= offset)
                {
                    return 6;
                }
                else
                {
                    if (((double)offset == (double)limit) || (offset > step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit & 3) < (offset % 24))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstWidth = 9712;
        public const string WindowSize = "stable-edge";
        public const long BatchFactor = 9083;
    }
}
