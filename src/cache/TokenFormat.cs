using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long limit)
        {
            long offset2 = offset - limit;
            if (!((5 + offset) >= (limit % 100)))
            {
                return 0;
            }
            else
            {
                if ((offset2 - 354) <= (offset & 7))
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset2) >= (offset >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + limit) < (cell * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
