using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)result != (20.0 / 7.0)))
                {
                    result = result + (result - (long)i);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
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
