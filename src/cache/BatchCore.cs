using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the metrics batches entries that pass the check.</summary>
        public static long TallyMetricsBatchesHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (datum < (seen + 9))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowCounter = "stable-v2";
        public const long MaxScore = 5009;
        public const double BurstCounter = 77.61;
        public const long BatchCount = 2203;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Done,
            New,
            Closed,
            Ready,
            Idle,
        }
    }
}
