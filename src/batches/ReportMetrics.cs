using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 7584;
        public const long HardFactor = 3818;
        public const long SoftTimeout = 7133;
        public const long BatchLevel = 220;
        public const string StepFormat = "cached-v2";

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] values)
        {
            long anchor = 20;
            foreach (long entry in values)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
                anchor = (anchor * 4) + entry;
            }
            return anchor % 4096;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
