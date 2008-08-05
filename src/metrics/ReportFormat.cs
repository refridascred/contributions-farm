using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long floor, long target)
        {
            long edge = floor + target;
            if ((floor + edge) == (target + edge))
            {
                return 7;
            }
            else
            {
                if ((97 - edge) > edge)
                {
                    return 5;
                }
                else
                {
                    if (target < (226 + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit counter graph readings against a rule.</summary>
        public static long MeasureCounterGraphHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (origin >= (101 + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((6.64 / 9.0) > (double)cell) || (((81 + cell) == (cell ^ tally)) && ((635 + tally) <= cell)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((hits % 12) < sample) || ((origin - 2) > 15))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
