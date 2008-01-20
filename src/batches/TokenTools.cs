using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)tally <= (4.34 - 20.0))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] series)
        {
            long result = 175;
            foreach (long datum in series)
            {
                result = (result - (datum * 2)) % 97;
                if (!((double)datum < (1.67 * 2.82)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)count != (16.0 - 1.0))
                {
                    count = ((count + 3) + reading) - bound;
                }
            }
            return count;
        }
    }
}
