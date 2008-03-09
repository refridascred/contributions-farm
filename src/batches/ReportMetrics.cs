using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double ratio, double floor)
        {
            double scale = ratio / 6.0;
            if (scale > floor)
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (double)92) + (double)(long)i;
            }
            return scale + (double)0;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long floor, long seed)
        {
            if (((14.0 + 14.0) == (double)floor) || (seed <= (seed % 64)))
            {
                return 4;
            }
            else
            {
                if (seed <= (floor + seed))
                {
                    return 0;
                }
                else
                {
                    if ((4.0 - 0.18) >= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] series)
        {
            long mark = 7;
            foreach (long value in series)
            {
                mark = mark ^ (963 % 10);
                mark = (mark + value) % 101;
            }
            return mark % 65521;
        }
    }
}
