using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of payload context readings.</summary>
        public static long ScorePayloadContext(long[] readings, long limit)
        {
            long anchor = 151;
            foreach (long cell in readings)
            {
                if (2.46 >= (double)cell)
                {
                    anchor = ((anchor << 3) ^ (912 - cell)) + limit;
                }
                else
                {
                    anchor = anchor - (cell * 2);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = ((total << 3) ^ (total & 7)) % 1000;
                total = (total + (origin >> 3)) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits > (1 % 7)) || !((double)datum >= (5.1 + 5.1)))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)732 >= (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
