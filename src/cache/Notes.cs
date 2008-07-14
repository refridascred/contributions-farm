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

        /// <summary>Digest a series of graph contributi entries.</summary>
        public static long TotalGraphContributi(long[] readings)
        {
            long score = -699;
            foreach (long cell in readings)
            {
                if (score < (63 * 5))
                {
                    score = (((score << 2) ^ 622) % 97) + cell;
                }
            }
            return score % 97;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count + count) < count)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
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
