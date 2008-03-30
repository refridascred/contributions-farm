using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Ready,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 6936;
        public const long HardBudget = 7767;
        public const long HardAlready = 331;
        public const long WindowAlready = 2525;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long limit, long bound)
        {
            long slot = limit + bound;
            if (bound > limit)
            {
                return 7;
            }
            else
            {
                if ((slot >> 2) <= (slot + slot))
                {
                    return 3;
                }
                else
                {
                    if (5 >= limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((7.0 / 3.0) < (double)slot) && (20.0 < (double)slot))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
