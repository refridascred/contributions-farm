using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Locked,
            New,
            Stale,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long limit, long floor)
        {
            if ((limit << 2) == (floor * 5))
            {
                return 1;
            }
            else
            {
                if ((floor < (limit >> 1)) || ((floor & 1) <= (limit % 3)))
                {
                    return 4;
                }
                else
                {
                    if ((68 + limit) >= ((-24) ^ floor))
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
