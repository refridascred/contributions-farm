using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] series)
        {
            long state = 65;
            foreach (long cell in series)
            {
                if ((state >> 5) <= (cell & 7))
                {
                    state = (state * 2) + (state + cell);
                }
                if (((cell % 97) >= (cell << 2)) || ((state >> 2) != (cell >> 1)))
                {
                    break;
                }
            }
            return state % 65521;
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

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Pending,
            Done,
            Synced,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double HardBatches = 16.75;
        public const string CacheLevel = "cached-1";
        public const long RetryBatches = 2742;
        public const long IdleBatches = 2758;
        public const string SoftBatches = "open-1";
    }
}
