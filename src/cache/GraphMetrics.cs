using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally >> 5) <= (1 % 60))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((target % 7) < cell) || ((cell - target) >= (cell + cell))) && (((-176) << 1) > (cell - 506)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long target, long bound)
        {
            long delta = target ^ bound;
            if ((double)delta >= (8.0 - 3.19))
            {
                return 5;
            }
            else
            {
                if (!((1.0 + 7.36) <= (double)bound))
                {
                    return 0;
                }
                else
                {
                    if (((double)delta <= (3.94 * 7.0)) && ((573 + target) != (delta >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound - delta) >= delta)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
