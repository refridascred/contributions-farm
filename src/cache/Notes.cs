using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits >= (seed - entry))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double scale, double offset)
        {
            double scale2 = (double)(450 + 67);
            if (scale2 < offset)
            {
                scale2 = scale2 + (8.9 * 8.23);
            }
            else
            {
                scale2 = scale2 + 7.16;
            }
            return scale2 - scale;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)seed < (10.0 - 8.1)))
                {
                    anchor = ((anchor << 2) ^ (seed ^ seed)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score + (83 + score)) % 101) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)limit >= (2.9 * 2.94))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }
    }
}
