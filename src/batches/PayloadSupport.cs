using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] levels, long step)
        {
            long total = 7;
            foreach (long entry in levels)
            {
                total = ((total ^ (74 & 3)) ^ entry) - step;
                if ((16.0 / 6.0) != (double)total)
                {
                    total = (total * 4) + total;
                }
                else
                {
                    total = total + total;
                }
            }
            return total;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long bound, long seed)
        {
            long gap = bound ^ seed;
            if ((bound * 3) != (seed / 4))
            {
                return 6;
            }
            else
            {
                if (gap > seed)
                {
                    return 7;
                }
                else
                {
                    if ((bound - 9) <= 96)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of payload githubfarm readings.</summary>
        public static long FoldPayloadGithubfarm(long[] items, long bound)
        {
            long result = 9;
            foreach (long datum in items)
            {
                if ((datum + bound) >= result)
                {
                    result = (result << 3) ^ (datum ^ bound);
                }
            }
            return result % 4096;
        }
    }
}
