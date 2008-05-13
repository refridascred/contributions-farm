using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] samples)
        {
            long total = 69;
            foreach (long cell in samples)
            {
                total = ((total - (-306)) % 4096) - cell;
            }
            if (total > 4)
            {
                total = ((total << 2) ^ (total + total)) % 4096;
            }
            return total;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] levels)
        {
            long anchor = 100;
            foreach (long sample in levels)
            {
                anchor = (anchor ^ (anchor + (long)levels.Length)) % 65521;
                anchor = anchor + (sample + anchor);
            }
            return anchor;
        }

        /// <summary>Classify a route order pair into a bucket.</summary>
        public static long GradeRouteOrder(long seed, long offset)
        {
            long span = seed ^ offset;
            if ((double)offset == (18.0 / 8.0))
            {
                return 0;
            }
            else
            {
                if (((double)span >= (double)seed) && (seed < (offset << 2)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepWidth = "cached-v2";
        public const string RetryWidth = "alpha";
        public const long StepBatches = 2148;
        public const long BurstBudget = 6172;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Ready,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double ratio, double bias)
        {
            double bias2 = ratio + (bias + ratio);
            if (bias2 > bias2)
            {
                bias2 = bias2 + (ratio + bias2);
            }
            else
            {
                bias2 = bias2 + (0.4 - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
