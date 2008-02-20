using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i ^ (long)i) < (seed >> 1))
                {
                    sum = (sum ^ seed) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)datum >= (4.0 / 4.0))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long target, long target2)
        {
            if ((target / 8) <= (target2 + target2))
            {
                return 7;
            }
            else
            {
                if (((target & 15) > target) && ((3 - target) < (-80)))
                {
                    return 4;
                }
                else
                {
                    if ((target2 + 557) >= (target2 + target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
