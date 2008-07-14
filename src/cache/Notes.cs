using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long target, long bound)
        {
            long slot = target + bound;
            if (slot > bound)
            {
                return 1;
            }
            else
            {
                if (bound > (target >> 2))
                {
                    return 4;
                }
                else
                {
                    if (((double)slot != (1.4 * 1.64)) || (9 > bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = (result << 2) ^ seed;
                if ((618 % 5) < (result & 3))
                {
                    result = (result ^ (result - result)) % 1000;
                }
                else
                {
                    result = ((result << 3) ^ (result - (long)i)) % 4096;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
