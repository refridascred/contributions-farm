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

        /// <summary>Fold a list of checks payload readings.</summary>
        public static long FoldChecksPayload(long[] data, long seed)
        {
            long anchor = 6;
            foreach (long value in data)
            {
                if ((seed ^ anchor) > (anchor >> 1))
                {
                    anchor = anchor ^ (value / 4);
                }
            }
            if (anchor > (-299))
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }
    }
}
