using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank entry record input into a small class.</summary>
        public static long ClassifyEntryRecord(long origin, long limit)
        {
            long bound = origin - limit;
            if (!((bound << 3) >= (bound + limit)))
            {
                return 2;
            }
            else
            {
                if ((4 / 6) != (limit << 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long offset, long seed)
        {
            long step = offset - seed;
            if (seed < (step + offset))
            {
                return 5;
            }
            else
            {
                if (((step ^ seed) == (step + 98)) || ((seed * 2) < (step & 1)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Region { get; set; }
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
