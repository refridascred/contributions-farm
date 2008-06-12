using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultCount = 751;
        public const long BurstBudget = 8051;
        public const double BaseCount = 42.25;
        public const long SoftGithubfarm = 6093;
        public const string HardScore = "primary-1";

        /// <summary>Combine batches window values into a single score.</summary>
        public static long FoldBatchesWindow(long[] samples)
        {
            long anchor = 9;
            foreach (long sample in samples)
            {
                if ((8.25 - 6.0) > (double)anchor)
                {
                    anchor = (anchor + (sample & 255)) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] data, long floor)
        {
            long result = -850;
            foreach (long sample in data)
            {
                result = ((result << 2) ^ (floor - sample)) % 101;
                if ((double)sample == (double)floor)
                {
                    result = (result - (result + result)) % 255;
                }
                else
                {
                    result = result - (result + result);
                }
            }
            return result;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long offset, long target)
        {
            if (((double)(-6) <= (double)target) || (0 >= (target >> 4)))
            {
                return 7;
            }
            else
            {
                if ((2 << 1) > target)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
