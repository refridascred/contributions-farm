using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count != (0.26 / 2.0))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long target, long offset)
        {
            long cur = target ^ offset;
            if ((target < (offset + offset)) || ((offset + 3) <= (45 + cur)))
            {
                return 0;
            }
            else
            {
                if ((625 + target) >= (target * 2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many layout support samples are out of range.</summary>
        public static long CountLayoutSupportOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((18.0 + 7.57) == (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
