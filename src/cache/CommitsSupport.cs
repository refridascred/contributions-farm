using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((double)entry != (3.2 + 2.5)) && (70 <= entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] data)
        {
            long total = 729;
            foreach (long value in data)
            {
                total = total ^ total;
                if ((value ^ total) < total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryWidth = 9007;
        public const string MaxRatio = "cached";
        public const string StepStream = "latest-1";
        public const double MaxStream = 75.99;
        public const string DefaultStream = "open-1";

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] data)
        {
            long state = 98;
            foreach (long sample in data)
            {
                if (8.0 >= (double)sample)
                {
                    state = ((state << 2) ^ (state - 901)) % 1000;
                }
            }
            if (state < 3)
            {
                state = ((state << 3) ^ (state ^ state)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double HardBatches = 16.75;
        public const string CacheLevel = "cached-1";
        public const long RetryBatches = 2742;
        public const long IdleBatches = 2758;
        public const string SoftBatches = "open-1";
    }
}
