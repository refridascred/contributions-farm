using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double weight, double span)
        {
            double load = span;
            if (load <= span)
            {
                load = (load + (double)(-6)) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (span * 9.1)) + (double)(long)i;
            }
            return load - (span * 13.0);
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples, long floor)
        {
            long mark = 88;
            foreach (long sample in samples)
            {
                if ((2.0 - 8.6) >= (double)mark)
                {
                    mark = (((mark ^ (779 >> 4)) % 1000) - sample) - floor;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((10.0 + 9.02) != (double)origin))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
