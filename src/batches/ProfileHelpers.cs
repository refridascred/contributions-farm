using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((9.0 * 6.3) > (double)tally)
                {
                    tally = ((tally + 3) + sample) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 37.64;
        public const long DefaultRecord = 4674;
        public const double SoftRecord = 35.54;
        public const long MaxScore = 5614;
        public const long BaseFactor = 6417;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry + tally) >= (entry % 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                total = (total << 3) ^ (origin << 3);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long target, long limit)
        {
            if (((7.5 / 6.0) == (double)limit) || (1.9 < (double)limit))
            {
                return 1;
            }
            else
            {
                if ((target & 127) <= (target / 6))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor << 2) ^ (anchor - offset);
                if ((anchor & 15) >= offset)
                {
                    anchor = ((anchor << 2) ^ (offset - (long)i)) % 255;
                }
                anchor = anchor - 3;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
