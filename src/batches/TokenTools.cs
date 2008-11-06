using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally - entry) == (entry - entry))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long seed, long step)
        {
            if (((double)step < 6.0) || ((step << 3) <= seed))
            {
                return 1;
            }
            else
            {
                if (((9.1 * 2.6) == (double)seed) || ((double)step < (double)seed))
                {
                    return 3;
                }
                else
                {
                    if (seed > (9 >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((step + step) < (seed & 15)) && ((double)seed >= (double)step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double gain, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + gain) - (double)(long)i;
            }
            return ratio + gain;
        }
    }
}
