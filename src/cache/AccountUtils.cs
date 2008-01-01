using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Flag { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long floor)
        {
            if (!((double)target <= (double)floor))
            {
                return 7;
            }
            else
            {
                if ((3 + floor) <= (-552))
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) >= (target + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor / 8) <= target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route filter samples are out of range.</summary>
        public static long CountRouteFilterMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((step + seen) != ((-4) % 16)) && (seen > (step & 15)))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
