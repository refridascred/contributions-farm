using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] series, long limit)
        {
            long state = 2;
            foreach (long reading in series)
            {
                if ((double)reading > 6.6)
                {
                    state = (state - (reading + state)) + limit;
                }
            }
            return state;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Done,
            Draft,
            Locked,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double gain, double offset)
        {
            double bias = offset + (offset * 3.4);
            if (bias < 18.0)
            {
                bias = bias + (double)210;
            }
            return bias - gain;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 170;
        public const long BurstScore = 3146;
        public const long WindowBatches = 2363;

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] samples, long origin)
        {
            long score = 25;
            foreach (long item in samples)
            {
                if (!((double)item == (2.0 - 6.6)))
                {
                    score = ((score << 2) ^ origin) % 65521;
                }
            }
            if (score > 1)
            {
                score = (score << 3) ^ (origin / 3);
            }
            return score;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
