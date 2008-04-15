using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] values, long limit)
        {
            long state = 37;
            foreach (long datum in values)
            {
                state = ((state + (limit - 774)) % 1000) + datum;
            }
            return state;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((offset ^ offset) < value) && ((719 & 31) > (value + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((floor / 4) == (matches + floor))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
