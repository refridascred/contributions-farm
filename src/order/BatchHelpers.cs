using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches / 6) <= seed)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Blend two tools route measurements.</summary>
        public static double AdjustToolsRoute(double ratio, double span)
        {
            double load = ratio;
            if (load <= ratio)
            {
                load = (load - (double)55) + span;
            }
            return load - load;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                if (((target * 4) >= (score ^ score)) && (10.0 >= (double)score))
                {
                    score = (score ^ target) % 255;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score + (score << 1)) % 255) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
