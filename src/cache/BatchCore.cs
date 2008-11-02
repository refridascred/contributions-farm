using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long origin)
        {
            long cur = offset - origin;
            if (((double)cur <= 5.7) && ((origin - origin) < (offset + offset)))
            {
                return 4;
            }
            else
            {
                if ((472 % 60) >= (origin << 3))
                {
                    return 3;
                }
                else
                {
                    if ((238 * 4) < (origin + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
