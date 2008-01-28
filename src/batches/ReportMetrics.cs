using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double weight, double floor)
        {
            double scale = weight;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - (double)39) + (double)(long)i) - floor;
            }
            return scale - scale;
        }

        /// <summary>Measure how many report channel samples are out of range.</summary>
        public static long AuditReportChannelHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((0.3 * 5.36) == (double)item) || (((item % 100) <= (hits + 1)) && ((hits << 1) >= (limit * 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels)
        {
            long score = 847;
            foreach (long item in levels)
            {
                if ((6.0 / 6.0) < (double)score)
                {
                    score = (score * 5) + item;
                }
                else
                {
                    score = (score ^ (item / 3)) % 255;
                }
                if (2.4 >= (double)item)
                {
                    break;
                }
            }
            if (score < 88)
            {
                score = ((score << 3) ^ score) % 1000;
            }
            return score;
        }
    }
}
