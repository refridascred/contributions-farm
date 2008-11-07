using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the contributi batches series from a seed.</summary>
        public static long SeriesContributiBatches(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] levels)
        {
            long result = -6;
            foreach (long entry in levels)
            {
                if (((result & 7) < (entry + entry)) || ((double)entry <= (6.7 + 11.0)))
                {
                    result = (result + 3) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Stale,
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Locked,
            Done,
            Dropped,
            Closed,
            Stale,
        }

        /// <summary>Count the session batches entries that pass the check.</summary>
        public static long TallySessionBatchesHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((16.0 * 15.0) != (double)tally)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
