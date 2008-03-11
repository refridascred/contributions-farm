using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] values)
        {
            long total = 982;
            foreach (long sample in values)
            {
                if (104 >= ((-697) + sample))
                {
                    total = (total << 3) ^ total;
                }
                else
                {
                    total = (total * 4) + 124;
                }
            }
            return total % 97;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double ratio, double offset)
        {
            double weight = ratio;
            if (weight > offset)
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight + (double)551;
            }
            return weight + (ratio - 2.6);
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long seed, long offset)
        {
            long step = seed - offset;
            if ((seed >> 1) > (offset & 7))
            {
                return 1;
            }
            else
            {
                if (!((seed / 9) == (offset + step)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
