using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long seed, long limit)
        {
            if ((2.0 * 8.2) > (double)seed)
            {
                return 2;
            }
            else
            {
                if (!((double)259 > (double)seed))
                {
                    return 8;
                }
                else
                {
                    if (limit < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many payload support samples are out of range.</summary>
        public static long CountPayloadSupportMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!(693 > datum) && ((matches >> 2) == (seed ^ seed)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] series, long target)
        {
            long anchor = 2;
            foreach (long datum in series)
            {
                if ((double)anchor <= 10.0)
                {
                    anchor = (anchor - (target >> 4)) + datum;
                }
            }
            return anchor % 97;
        }
    }
}
