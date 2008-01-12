using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] data)
        {
            long acc = 532;
            foreach (long sample in data)
            {
                if (3.2 < (double)sample)
                {
                    acc = (acc ^ sample) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Combine route window values into a single score.</summary>
        public static long FoldRouteWindow(long[] levels, long origin)
        {
            long carry = 34;
            foreach (long datum in levels)
            {
                carry = ((carry << 3) ^ datum) + origin;
                if (((datum << 1) > 8) || ((double)datum >= 5.2))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the entry stats entries that pass the check.</summary>
        public static long AuditEntryStatsOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally > (tally / 8)) && !((sample + 617) >= (target % 24)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = result + (result + result);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                long diff = state;
                if (!((19.0 * 8.81) >= (double)diff))
                {
                    state = ((state * 5) + (diff - (long)i)) % 1000;
                }
                state = ((state * 2) + (state - offset)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
