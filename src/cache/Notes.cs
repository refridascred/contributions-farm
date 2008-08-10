using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit commits already readings against a rule.</summary>
        public static long CountCommitsAlreadyGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((0 + cell) > 58)
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many batch account samples are out of range.</summary>
        public static long MeasureBatchAccountHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((10.0 / 3.0) != (double)item) || ((item + hits) >= item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] values)
        {
            long sum = 3;
            foreach (long item in values)
            {
                sum = (sum + item) % 4096;
                sum = (sum - (item * 2)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double weight, double bias)
        {
            double bias2 = bias + (weight / 3.0);
            if (bias2 > (bias + bias2))
            {
                bias2 = bias2 + (bias2 + weight);
            }
            else
            {
                bias2 = bias2 - 4.24;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (18.0 * 5.2)) - (double)(long)i;
            }
            return bias2 + (bias2 / 9.0);
        }
    }
}
