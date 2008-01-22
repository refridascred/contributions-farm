using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the batch channel entries that pass the check.</summary>
        public static long TallyBatchChannelHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + cell) >= 501)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long seed, long seed2)
        {
            long delta = seed + seed2;
            if ((delta - delta) != (seed * 4))
            {
                return 7;
            }
            else
            {
                if ((delta - 3) > (delta ^ seed))
                {
                    return 2;
                }
                else
                {
                    if (!((seed / 4) != (seed2 * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
