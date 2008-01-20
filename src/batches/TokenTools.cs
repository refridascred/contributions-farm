using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
