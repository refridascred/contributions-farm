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

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowBatch = 25.66;
        public const long IdleLevel = 2158;
        public const string BaseBudget = "local-v2";

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
