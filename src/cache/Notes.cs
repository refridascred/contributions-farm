using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings, long origin)
        {
            long mix = 358;
            foreach (long entry in readings)
            {
                if (6 < (mix - origin))
                {
                    mix = ((mix + (mix + 15)) % 65521) ^ entry;
                }
            }
            return mix % 65521;
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

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Active,
            Queued,
            Synced,
            Closed,
        }
    }
}
