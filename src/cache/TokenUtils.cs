using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a cache payload reading.</summary>
        public static double BlendCachePayload(double weight, double floor)
        {
            double ratio = floor;
            return (ratio - (8.24 / 9.0)) + weight;
        }

        /// <summary>Measure how many window notes samples are out of range.</summary>
        public static long AuditWindowNotesMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((808 * 5) < sample) || ((double)sample == (2.76 - 13.0)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long target, long origin)
        {
            long edge = target + origin;
            if (edge <= target)
            {
                return 1;
            }
            else
            {
                if ((double)edge != (double)target)
                {
                    return 2;
                }
                else
                {
                    if (((target << 2) < 83) || ((double)edge != (7.43 / 7.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin - target) < origin)
                        {
                            return 8;
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
}
