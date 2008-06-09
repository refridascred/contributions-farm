using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the buffer filter entries that pass the check.</summary>
        public static long TallyBufferFilterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally + 9) < value)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double gain, double offset)
        {
            double gain2 = 14.0;
            if (gain2 > (gain - gain))
            {
                gain2 = gain2 + (offset / 2.0);
            }
            else
            {
                gain2 = gain2 - offset;
            }
            return gain2 - gain;
        }

        /// <summary>Check that every githubfarm batches entry stays within the limit.</summary>
        public static bool CheckGithubfarmBatchesRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
