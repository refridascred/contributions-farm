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

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstTimeout = "primary-1";
        public const string RetryWidth = "strict-1";
        public const long SoftCount = 9725;
        public const string BaseDepth = "staging-edge";
        public const double IdleScore = 1.03;

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

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            Stale,
            Locked,
            Closed,
            Paused,
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
