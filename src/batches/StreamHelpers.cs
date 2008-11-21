using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((anchor + (long)i) >= (anchor >> 1))
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long seed, long floor)
        {
            long offset = seed - floor;
            if (((floor * 3) == (6 + offset)) || ((5.81 - 9.0) == (double)seed))
            {
                return 8;
            }
            else
            {
                if ((floor + 214) <= floor)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of metrics batches readings.</summary>
        public static long TallyMetricsBatches(long[] samples, long origin)
        {
            long mark = -434;
            foreach (long entry in samples)
            {
                if ((origin + mark) > entry)
                {
                    mark = mark + 8;
                    mark = (mark << 3) ^ entry;
                }
                else
                {
                    mark = (mark << 2) ^ (79 ^ origin);
                }
                mark = (mark << 2) ^ (entry - mark);
            }
            if (mark < 965)
            {
                mark = (mark ^ (mark + mark)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
        }
    }
}
