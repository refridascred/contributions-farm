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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a farm entry pair into a bucket.</summary>
        public static long ClassifyFarmEntry(long floor, long offset)
        {
            long offset2 = floor ^ offset;
            if ((offset > (90 * 4)) && ((floor % 3) < (offset * 2)))
            {
                return 3;
            }
            else
            {
                if ((offset2 ^ floor) != (offset2 - 660))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
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
