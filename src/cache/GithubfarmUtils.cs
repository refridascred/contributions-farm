using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 9890;
        public const long BatchBatches = 1167;
        public const string CacheInterval = "fallback-v2";
        public const string StepBatches = "latest-edge";

        /// <summary>Measure how many support queue samples are out of range.</summary>
        public static long MeasureSupportQueueGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= (double)77)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
