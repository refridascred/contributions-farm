using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit session already readings against a rule.</summary>
        public static long AuditSessionAlreadyHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)(long)items.Length <= (5.6 - 11.0))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long limit, long floor)
        {
            long gap = limit ^ floor;
            if ((limit - 579) > (floor & 3))
            {
                return 4;
            }
            else
            {
                if ((limit ^ floor) > (floor + 27))
                {
                    return 5;
                }
                else
                {
                    if (((limit + floor) <= (725 >> 3)) || (gap < (35 >> 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((limit >> 5) >= (floor - gap)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
