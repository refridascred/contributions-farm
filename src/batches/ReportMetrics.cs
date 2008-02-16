using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double scale, double floor)
        {
            double rate = floor;
            if (rate > 2.0)
            {
                rate = (rate + rate) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the stream editor series from a seed.</summary>
        public static long SeriesStreamEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                long lane = (long)i ^ ((long)i >> 1);
                mark = (mark + (lane << 1)) % 101;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
