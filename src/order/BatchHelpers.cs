using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Audit batch cluster readings against a rule.</summary>
        public static long CountBatchClusterHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((target ^ target) < (hits - hits))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Closed,
            Active,
            Failed,
            Dropped,
        }
    }
}
