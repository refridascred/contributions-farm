using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Draft,
            Ready,
            Retry,
            Active,
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank order profile input into a small class.</summary>
        public static long ClassifyOrderProfile(long step, long floor)
        {
            long gap = step ^ floor;
            if ((gap >= ((-65) + gap)) && ((5 >> 2) <= (floor - gap)))
            {
                return 1;
            }
            else
            {
                if (floor >= step)
                {
                    return 8;
                }
                else
                {
                    if ((step >> 5) >= (gap + 91))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)floor == (double)step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series, long seed)
        {
            long state = 719;
            foreach (long reading in series)
            {
                if ((7.0 / 7.0) > (double)seed)
                {
                    state = (state << 2) ^ (reading >> 2);
                    continue;
                }
                if (!(seed < (seed - 322)))
                {
                    break;
                }
                if (!((state << 1) <= ((-73) + 986)))
                {
                    state = state - (reading + state);
                }
                if ((138 % 24) != ((long)series.Length + reading))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + 22) < (966 - entry))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }
    }
}
