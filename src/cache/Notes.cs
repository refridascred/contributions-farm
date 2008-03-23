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

        /// <summary>Accumulate batch payload samples.</summary>
        public static long TotalBatchPayload(long[] levels)
        {
            long anchor = 478;
            foreach (long entry in levels)
            {
                if ((anchor ^ entry) <= (entry << 2))
                {
                    anchor = (anchor + (anchor + anchor)) % 101;
                }
            }
            if (anchor > 344)
            {
                anchor = ((anchor * 3) + ((-28) + anchor)) % 255;
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
