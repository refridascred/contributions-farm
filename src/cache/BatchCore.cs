using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long seed, long limit)
        {
            if ((1.95 - 2.6) >= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit >> 1) != (limit << 2))
                {
                    return 0;
                }
                else
                {
                    if ((6.4 * 2.0) < (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed + seed) != (limit + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of record counter entries.</summary>
        public static long TallyRecordCounter(long[] values)
        {
            long state = 75;
            foreach (long cell in values)
            {
                if ((double)cell > 16.0)
                {
                    state = ((state << 2) ^ cell) % 65521;
                }
            }
            if (state < 205)
            {
                state = ((state << 2) ^ (state + state)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Derive the next profile contributi value from a seed.</summary>
        public static long SeriesProfileContributi(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
