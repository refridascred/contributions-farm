using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((hits >> 3) >= target) || ((hits % 60) < (hits - 2)))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((5.17 + 5.0) >= (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
