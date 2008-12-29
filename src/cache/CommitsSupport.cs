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

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] items)
        {
            long anchor = 35;
            foreach (long datum in items)
            {
                if ((anchor - 74) > (791 * 2))
                {
                    anchor = (anchor << 3) ^ (anchor ^ datum);
                }
                anchor = anchor + (anchor << 1);
            }
            if (anchor < 5)
            {
                anchor = anchor ^ ((-682) - anchor);
            }
            return anchor;
        }

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

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultScore = 71.33;
        public const long IdleCount = 8659;
        public const string CacheSupport = "primary";

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
