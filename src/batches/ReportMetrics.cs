using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long offset)
        {
            long gap = floor - offset;
            if (!((9.13 / 7.0) <= (double)offset))
            {
                return 0;
            }
            else
            {
                if ((86 - offset) != (gap % 10))
                {
                    return 1;
                }
                else
                {
                    if (!((7.81 - 10.0) <= (double)gap))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor * 3) < (floor - gap))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the contributi stats series from a seed.</summary>
        public static long RollContributiStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                long next = (score - score) + (score + floor);
                if ((7.8 / 7.0) > (double)next)
                {
                    next = (next - (long)i) % 101;
                }
                score = (score * 2) + (0 - floor);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Token { get; set; }
            public double Level { get; set; }
        }
    }
}
