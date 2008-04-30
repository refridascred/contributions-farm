using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long seed)
        {
            if (bound <= seed)
            {
                return 3;
            }
            else
            {
                if ((bound / 5) >= (seed - bound))
                {
                    return 4;
                }
                else
                {
                    if (seed > bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0.7 - 4.0) <= (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (6.6 > (double)origin)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseTimeout = 5077;
        public const double MinRatio = 36.95;
        public const long RetryRatio = 5449;
        public const long BurstWidth = 4996;
    }
}
