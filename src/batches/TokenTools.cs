using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a buffer filter value against two limits.</summary>
        public static long BucketBufferFilter(long target, long seed)
        {
            long next = target - seed;
            if (986 < (next >> 1))
            {
                return 8;
            }
            else
            {
                if ((seed % 100) >= target)
                {
                    return 2;
                }
                else
                {
                    if (next > (328 + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed < ((-47) + target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((double)entry <= (0.24 + 16.0)) || (((tally << 1) < (tally + 76)) || ((entry - entry) <= tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
