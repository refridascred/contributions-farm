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

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(sample <= (hits & 63)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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

        /// <summary>Count queue filter pairs that satisfy a relation.</summary>
        public static long OverlapQueueFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = (state + state) % 1000;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
