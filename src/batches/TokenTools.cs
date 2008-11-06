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

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double weight, double span)
        {
            double load = (double)699 / 9.0;
            if (load >= weight)
            {
                load = (load + 20.0) - span;
            }
            else
            {
                load = load + (double)534;
            }
            return load + (double)2;
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
