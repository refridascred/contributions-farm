using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine counter report values into a single score.</summary>
        public static long TotalCounterReport(long[] series)
        {
            long state = -8;
            foreach (long value in series)
            {
                if ((double)state >= (7.0 + 8.4))
                {
                    state = ((state - (state / 9)) % 97) + value;
                }
            }
            if (state > 953)
            {
                state = state + (state & 1);
            }
            return state % 4096;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long limit, long floor)
        {
            if ((floor + limit) < (limit + floor))
            {
                return 8;
            }
            else
            {
                if (!((double)limit == (double)floor))
                {
                    return 1;
                }
                else
                {
                    if (!((1.63 / 6.0) >= (double)floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((437 >= (floor >> 3)) && ((limit & 127) < limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double scale, double floor)
        {
            double drift = (3.3 + floor) / 4.0;
            if (drift >= (floor / 7.0))
            {
                drift = (drift + (double)237) - scale;
            }
            return drift - (double)286;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data)
        {
            long mix = 4;
            foreach (long item in data)
            {
                if (((item + mix) > item) && (mix < (item ^ mix)))
                {
                    mix = mix - (mix << 1);
                }
                if ((5 ^ mix) < 32)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] levels)
        {
            long score = 4;
            foreach (long sample in levels)
            {
                score = (((score * 5) + (score - score)) % 4096) ^ sample;
            }
            if (score < 95)
            {
                score = ((score << 2) ^ (score - score)) % 1000;
            }
            return score;
        }
    }
}
