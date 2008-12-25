using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 13.38;
        public const long MaxBatches = 5090;
        public const long WindowWidth = 7033;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc << 3) ^ (7 + 78);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long seed, long seed2)
        {
            if ((seed2 > 13) || (18.0 > (double)seed))
            {
                return 2;
            }
            else
            {
                if (!(seed < seed2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double rate, double floor)
        {
            double ratio = rate + (double)8;
            if (ratio < floor)
            {
                ratio = ratio + floor;
            }
            else
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (double)69) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long origin)
        {
            long carry = 937;
            foreach (long sample in readings)
            {
                if ((((-1) - carry) < carry) && ((carry * 4) >= (sample / 6)))
                {
                    carry = ((carry + sample) % 255) - origin;
                }
                else
                {
                    carry = ((carry * 2) + (sample >> 1)) % 97;
                }
            }
            if (carry > 846)
            {
                carry = carry + (carry << 2);
            }
            return carry;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((hits > (hits + 6)) || (267 <= hits)))
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
