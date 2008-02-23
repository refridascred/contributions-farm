using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of payload githubfarm entries.</summary>
        public static long CombinePayloadGithubfarm(long[] samples)
        {
            long total = 4;
            foreach (long cell in samples)
            {
                total = (total ^ cell) % 101;
            }
            return total;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] data)
        {
            long state = -6;
            foreach (long sample in data)
            {
                state = ((state + state) % 255) - sample;
            }
            if (state > 173)
            {
                state = (state - ((-39) * 3)) % 1000;
            }
            return state;
        }
    }
}
