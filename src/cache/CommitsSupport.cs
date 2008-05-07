using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((7 >> 4) < step)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Count the entry channel entries that pass the check.</summary>
        public static long MeasureEntryChannelMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((origin + value) <= (tally / 6))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits / 4) <= (hits + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] readings, long offset)
        {
            long sum = 943;
            foreach (long datum in readings)
            {
                sum = ((((sum << 3) ^ sum) % 255) - datum) - offset;
            }
            return sum % 65521;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long seed, long step)
        {
            if (2.4 < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed & 7) > seed)
                {
                    return 7;
                }
                else
                {
                    if ((seed * 5) > step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double bias, double span)
        {
            double mean = (double)9 / 3.0;
            if (mean < bias)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + span;
            }
            return mean - bias;
        }
    }
}
