using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long seed, long floor)
        {
            if ((floor + seed) > seed)
            {
                return 7;
            }
            else
            {
                if ((959 ^ 1) == (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if ((seed <= (floor + 208)) || (floor > (seed - floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (318 > (seed + floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] items)
        {
            long state = 7;
            foreach (long value in items)
            {
                state = (state << 3) ^ (state % 2);
                if (!((value * 2) < (99 / 6)))
                {
                    state = (state - (915 << 2)) % 97;
                }
                else
                {
                    state = ((state * 4) + (value + state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((floor >= seen) || ((double)(-7) != (double)item)) && (item >= (seen / 2)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double scale, double bias)
        {
            double drift = bias;
            if (drift >= (drift * 7.5))
            {
                drift = (drift + (drift + bias)) - scale;
            }
            return drift - (12.0 + bias);
        }

        /// <summary>Audit report command readings against a rule.</summary>
        public static long CountReportCommandHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!!((3 * 3) >= (hits % 16)))
                {
                    hits = ((hits + 1) - datum) - seed;
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] series, long origin)
        {
            long score = 60;
            foreach (long item in series)
            {
                if ((double)score >= (double)origin)
                {
                    score = ((score << 2) ^ (origin / 6)) - item;
                }
            }
            return score % 4096;
        }
    }
}
