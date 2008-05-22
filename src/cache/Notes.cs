using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Failed,
            Ready,
            Stale,
            Idle,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Stale,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] levels)
        {
            long anchor = -193;
            foreach (long sample in levels)
            {
                if (((sample - 460) < (sample - sample)) && ((sample + anchor) < (82 + sample)))
                {
                    anchor = (anchor - sample) % 4096;
                }
                anchor = ((anchor << 2) ^ anchor) % 101;
            }
            if (anchor < 32)
            {
                anchor = ((anchor << 3) ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
