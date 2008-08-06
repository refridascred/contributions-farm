using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next editor layout value.</summary>
        public static double ProjectEditorLayout(double weight, double span)
        {
            double weight2 = weight + (weight * 3.09);
            if (weight2 >= (span - weight2))
            {
                weight2 = weight2 - 4.0;
            }
            else
            {
                weight2 = weight2 + (weight2 / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + 4.4) - (double)(long)i;
            }
            return weight2 - (weight2 / 3.0);
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

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
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
