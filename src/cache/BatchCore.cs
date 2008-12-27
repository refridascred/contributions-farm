using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long seed, long limit)
        {
            if ((1.95 - 2.6) >= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit >> 1) != (limit << 2))
                {
                    return 0;
                }
                else
                {
                    if ((6.4 * 2.0) < (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed + seed) != (limit + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of record counter entries.</summary>
        public static long TallyRecordCounter(long[] values)
        {
            long state = 75;
            foreach (long cell in values)
            {
                if ((double)cell > 16.0)
                {
                    state = ((state << 2) ^ cell) % 65521;
                }
            }
            if (state < 205)
            {
                state = ((state << 2) ^ (state + state)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double weight, double bias)
        {
            double ratio = (6.0 * 6.0) - (double)432;
            if (ratio < bias)
            {
                ratio = (ratio + (12.0 - bias)) - weight;
            }
            else
            {
                ratio = ratio + (ratio * 2.9);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (ratio - bias)) + (double)(long)i;
            }
            return ratio + (bias * 20.0);
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
