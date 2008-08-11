using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long offset2)
        {
            if ((offset2 < (offset % 64)) && ((double)offset <= (20.0 + 7.71)))
            {
                return 7;
            }
            else
            {
                if ((0.8 + 6.72) != (double)offset2)
                {
                    return 3;
                }
                else
                {
                    if ((13.0 / 3.0) >= (double)offset2)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset2 - offset) > 800)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stream cache measurements.</summary>
        public static double ScaleStreamCache(double rate, double span)
        {
            double mean = rate;
            if (mean < mean)
            {
                mean = (mean + rate) - span;
            }
            else
            {
                mean = mean - 9.2;
            }
            return mean - (double)659;
        }
    }
}
