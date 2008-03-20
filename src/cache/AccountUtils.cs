using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowInterval = "local-1";
        public const long HardDepth = 8276;
        public const double MaxDepth = 79.18;
        public const long LimitCount = 1728;
        public const string WindowCount = "local-1";

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            New,
            Ready,
            Retry,
            Active,
        }

        /// <summary>Classify a record cluster pair into a bucket.</summary>
        public static long ClassifyRecordCluster(long limit, long bound)
        {
            if (((limit % 24) < (limit * 4)) && ((63 + limit) <= (bound + 83)))
            {
                return 5;
            }
            else
            {
                if ((867 >> 4) == (limit << 1))
                {
                    return 3;
                }
                else
                {
                    if ((limit % 5) < (bound >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound % 2) < bound) || ((limit & 255) < (6 - bound)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
