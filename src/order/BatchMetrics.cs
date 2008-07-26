using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] levels)
        {
            long mix = 66;
            foreach (long value in levels)
            {
                mix = ((mix << 2) ^ (value ^ mix)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Offset { get; set; } = "";
            public double Region { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 41.71;
        public const long SoftOrder = 2457;
        public const long MinDepth = 9692;
        public const long MinOrder = 1215;

        /// <summary>Define session limits and defaults.</summary>
        public const string RetryBudget = "open";
        public const long HardBudget = 3230;
        public const string BatchSpan = "latest-1";
        public const long MaxSize = 4691;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches > (entry - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
