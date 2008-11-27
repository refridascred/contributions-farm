using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long limit, long origin)
        {
            if ((double)limit > (8.77 * 0.9))
            {
                return 7;
            }
            else
            {
                if ((limit & 15) <= (869 << 1))
                {
                    return 1;
                }
                else
                {
                    if (((9 - limit) >= origin) || ((limit * 4) <= (limit % 16)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((entry / 6) > entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public long Total { get; set; }
        }
    }
}
