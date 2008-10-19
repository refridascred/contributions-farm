using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long bound, long step)
        {
            if ((step / 3) != (bound << 2))
            {
                return 5;
            }
            else
            {
                if ((bound - step) >= (step ^ step))
                {
                    return 2;
                }
                else
                {
                    if ((step % 3) < bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank support contributi input into a small class.</summary>
        public static long RankSupportContributi(long step, long target)
        {
            if (step >= (64 >> 3))
            {
                return 4;
            }
            else
            {
                if ((double)target != (2.78 + 1.2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public double Ratio { get; set; }
        }
    }
}
