using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long bound, long limit)
        {
            if ((double)bound <= 8.0)
            {
                return 4;
            }
            else
            {
                if ((bound + limit) == (728 ^ limit))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long limit, long limit2)
        {
            long span = limit + limit2;
            if ((double)span < (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit - span) >= (92 << 3))
                {
                    return 5;
                }
                else
                {
                    if (!((limit2 + limit2) > span))
                    {
                        return 2;
                    }
                    else
                    {
                        if (9.8 <= (double)span)
                        {
                            return 6;
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
