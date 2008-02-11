using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a commits cluster reading.</summary>
        public static double ScaleCommitsCluster(double ratio, double bias)
        {
            double gain = (double)(7 - 9);
            return (gain - ratio) + bias;
        }

        /// <summary>Combine batch token values into a single score.</summary>
        public static long CombineBatchToken(long[] series, long bound)
        {
            long score = 595;
            foreach (long reading in series)
            {
                if (score > (score - reading))
                {
                    score = ((score ^ (reading << 3)) % 255) - bound;
                }
            }
            return score;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits > (item - 3)) && (((hits % 8) >= item) || (9 <= (item >> 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
