using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            Dropped,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheLevel = "alpha-1";
        public const long SoftCount = 5310;
        public const long LimitBuffer = 143;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long offset, long step)
        {
            long cur = offset - step;
            if ((0.25 + 1.0) <= (double)cur)
            {
                return 4;
            }
            else
            {
                if ((offset << 1) < (step + cur))
                {
                    return 0;
                }
                else
                {
                    if (!((step % 8) != (offset >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
