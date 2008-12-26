using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long offset)
        {
            long edge = origin + offset;
            if (origin < (origin >> 5))
            {
                return 2;
            }
            else
            {
                if ((edge - edge) >= (edge + offset))
                {
                    return 0;
                }
                else
                {
                    if ((origin << 3) >= (origin * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((12.0 / 5.0) <= (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Retry,
            Idle,
            New,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Paused,
            Pending,
            Idle,
        }
    }
}
