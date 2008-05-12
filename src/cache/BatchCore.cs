using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double gain2 = span + (1.1 * 3.7);
            if (gain2 > (double)410)
            {
                gain2 = gain2 - (span / 9.0);
            }
            return gain2 + gain;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long result = 866;
            foreach (long entry in levels)
            {
                result = result + (result * 4);
                if (46 >= (0 + result))
                {
                    result = (result * 2) + entry;
                }
            }
            if (result > 888)
            {
                result = (result * 2) + (result - result);
            }
            return result % 97;
        }
    }
}
