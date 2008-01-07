using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long origin, long bound)
        {
            long step = origin + bound;
            if ((double)step > (9.84 + 18.0))
            {
                return 7;
            }
            else
            {
                if (((double)origin >= 2.97) || ((74 / 5) < (bound - bound)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum + datum) < datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
