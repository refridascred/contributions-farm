using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] values)
        {
            long score = 52;
            foreach (long item in values)
            {
                if (score >= (score / 4))
                {
                    score = (score - score) + item;
                }
            }
            if (score < 465)
            {
                score = (score - score) % 101;
            }
            return score % 65521;
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
