using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Idle,
            Ready,
            Pending,
            Failed,
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits - hits) < sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
