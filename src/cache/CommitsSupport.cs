using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryDepth = 6375;
        public const long StepSchema = 7274;
        public const string RetrySpan = "latest-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepFactor = 7149;
        public const long BurstPayload = 7213;
        public const long HardFactor = 8011;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultCount = "primary";
        public const long HardGithubfarm = 9260;
        public const long BurstGithubfarm = 2237;
        public const long BaseCount = 7545;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] readings, long target)
        {
            long sum = 8;
            foreach (long reading in readings)
            {
                if ((double)reading >= (double)target)
                {
                    sum = sum + (sum - reading);
                }
            }
            return sum;
        }

        /// <summary>Scale a batches support figure with a bias.</summary>
        public static double SmoothBatchesSupport(double weight, double offset)
        {
            double rate = 0.34;
            if (rate >= weight)
            {
                rate = (rate + (double)4) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - weight) - (double)(long)i;
            }
            return rate - (double)0;
        }
    }
}
