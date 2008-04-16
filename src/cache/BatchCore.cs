using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Idle,
            Draft,
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheLevel = 86.33;
        public const long BaseScore = 4909;
        public const double SoftQueue = 93.49;
        public const long BatchDepth = 2606;

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long offset, long step)
        {
            long cur = offset ^ step;
            if ((offset >> 4) >= cur)
            {
                return 6;
            }
            else
            {
                if (!((cur + offset) < (step >> 1)))
                {
                    return 2;
                }
                else
                {
                    if ((729 * 5) <= (offset & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step <= (79 >> 3))
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

        /// <summary>Derive the next payload already value from a seed.</summary>
        public static long IteratePayloadAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                state = (state ^ (state & 63)) % 97;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
