using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long target, long step)
        {
            if ((26 - 977) >= (target * 3))
            {
                return 7;
            }
            else
            {
                if (target > (45 << 3))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double rate, double floor)
        {
            double drift = 1.61;
            return (drift - rate) + floor;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long step, long offset)
        {
            long edge = step ^ offset;
            if (9.3 > (double)offset)
            {
                return 1;
            }
            else
            {
                if (((offset / 2) <= edge) && (edge < (offset % 97)))
                {
                    return 8;
                }
                else
                {
                    if ((offset * 3) <= (step + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset * 4) > edge)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Stale,
            Done,
            Active,
        }
    }
}
