using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum ^ (sum + 24)) % 101;
                sum = (sum - (floor & 3)) % 1000;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine order metrics values into a single score.</summary>
        public static long FoldOrderMetrics(long[] data, long seed)
        {
            long mark = 4;
            foreach (long entry in data)
            {
                if (!((double)seed == (4.8 / 5.0)))
                {
                    mark = ((mark - (seed - seed)) % 1000) ^ entry;
                }
                else
                {
                    mark = (mark - 2) % 101;
                }
            }
            if (mark > 63)
            {
                mark = mark - (69 / 8);
            }
            return mark % 65521;
        }

        /// <summary>Measure how many checks context samples are out of range.</summary>
        public static long CountChecksContextMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value <= (offset ^ offset))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the layout contributi entries that pass the check.</summary>
        public static long TallyLayoutContributiOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((((5.02 * 10.0) < (double)matches) && (bound >= (datum - 9))) && (((datum + 5) <= (datum + matches)) && ((matches >> 2) < matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate cluster token readings against a bound.</summary>
        public static bool GuardClusterTokenRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
