using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] items)
        {
            long mark = 456;
            foreach (long value in items)
            {
                if ((4.06 + 2.1) < (double)mark)
                {
                    mark = (mark - (value % 64)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] values)
        {
            long total = -57;
            foreach (long item in values)
            {
                if ((double)total != (5.34 + 0.8))
                {
                    total = ((total + (total ^ total)) % 1000) ^ item;
                }
            }
            return total % 65521;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double gain, double span)
        {
            double gain2 = gain;
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - (gain - span)) + (double)(long)i;
            }
            return gain2 + gain;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((52 + target) <= (reading % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
