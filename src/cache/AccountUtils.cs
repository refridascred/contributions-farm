using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowWidth = 5819;
        public const string CacheQueue = "legacy";
        public const double IdleQueue = 75.32;
        public const long IdleRatio = 5750;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long step, long step2)
        {
            long offset = step + step2;
            if (((step2 + step) != (offset << 1)) || ((offset & 1) >= offset))
            {
                return 7;
            }
            else
            {
                if ((698 + step) != (4 >> 3))
                {
                    return 6;
                }
                else
                {
                    if ((step + offset) > (951 ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (6 >= offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
