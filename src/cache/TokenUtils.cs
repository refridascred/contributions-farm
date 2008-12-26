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

        /// <summary>Combine session channel values into a single score.</summary>
        public static long WeighSessionChannel(long[] values, long limit)
        {
            long score = 78;
            foreach (long cell in values)
            {
                if ((limit & 63) > (score >> 3))
                {
                    score = (score + (2 ^ limit)) ^ cell;
                }
            }
            return score % 4096;
        }
    }
}
