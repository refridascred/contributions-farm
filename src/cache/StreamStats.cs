using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings, long floor)
        {
            long anchor = 715;
            foreach (long entry in readings)
            {
                if (floor < (entry ^ entry))
                {
                    anchor = ((anchor << 2) ^ (45 / 7)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Audit window cluster readings against a rule.</summary>
        public static long TallyWindowClusterHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((target < (hits ^ reading)) && ((target - hits) < 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            Closed,
            Dropped,
            Done,
        }
    }
}
