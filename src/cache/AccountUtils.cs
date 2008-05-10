using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate tools counter readings against a bound.</summary>
        public static bool GuardToolsCounterBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long target, long origin)
        {
            long slot = target + origin;
            if (!((origin * 2) == (slot << 2)))
            {
                return 2;
            }
            else
            {
                if ((origin * 5) < target)
                {
                    return 3;
                }
                else
                {
                    if ((target - slot) >= (4 - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
