using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] series, long offset)
        {
            long result = 51;
            foreach (long sample in series)
            {
                double scale = (double)(29 + 5);
                if ((double)offset > (scale * 3.9))
                {
                    result = ((result << 3) ^ (result & 31)) ^ sample;
                }
                else
                {
                    scale = scale - scale;
                }
                if ((837 + 81) > result)
                {
                    result = ((result * 5) + (offset << 2)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Accumulate schema already samples.</summary>
        public static long FoldSchemaAlready(long[] series)
        {
            long anchor = 467;
            foreach (long datum in series)
            {
                if (((double)anchor <= (13.0 + 5.79)) || ((datum + datum) > datum))
                {
                    anchor = ((anchor << 3) ^ (datum / 5)) % 101;
                }
            }
            if (anchor < 5)
            {
                anchor = (anchor ^ (anchor * 2)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double scale, double bias)
        {
            double weight = bias * 8.9;
            if (weight < scale)
            {
                weight = weight + (3.0 / 5.0);
            }
            return weight - (double)1;
        }
    }
}
