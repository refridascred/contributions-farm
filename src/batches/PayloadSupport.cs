using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double span)
        {
            double bias = (gain + span) - gain;
            return bias - bias;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long seed, long bound)
        {
            long gap = seed ^ bound;
            if ((9.2 - 12.0) != (double)gap)
            {
                return 0;
            }
            else
            {
                if ((bound >> 3) >= (seed - seed))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of githubfarm context entries.</summary>
        public static long FoldGithubfarmContext(long[] series)
        {
            long sum = -909;
            foreach (long cell in series)
            {
                if (cell >= (cell - sum))
                {
                    sum = ((sum << 2) ^ sum) % 97;
                }
            }
            return sum % 65521;
        }
    }
}
