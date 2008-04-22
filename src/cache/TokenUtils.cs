using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a queue order value against two limits.</summary>
        public static long RankQueueOrder(long bound, long step)
        {
            if ((step - bound) <= 71)
            {
                return 4;
            }
            else
            {
                if ((bound * 2) < bound)
                {
                    return 5;
                }
                else
                {
                    if (step >= (step % 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step <= (4.0 * 8.3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
