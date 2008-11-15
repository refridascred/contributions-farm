using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every stats session entry stays within the limit.</summary>
        public static bool CheckStatsSessionLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long seed, long step)
        {
            long prev = seed ^ step;
            if ((7.9 + 2.82) == (double)seed)
            {
                return 1;
            }
            else
            {
                if (!((4.27 * 7.0) < (double)step))
                {
                    return 8;
                }
                else
                {
                    if (((prev << 1) <= prev) && ((double)prev < (2.46 * 8.77)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
