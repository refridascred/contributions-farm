using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long floor, long bound)
        {
            if ((bound - 33) < (floor % 60))
            {
                return 0;
            }
            else
            {
                if (((double)bound < 5.36) || ((2 + floor) < bound))
                {
                    return 2;
                }
                else
                {
                    if (3.89 <= (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long origin, long bound)
        {
            if (bound <= origin)
            {
                return 6;
            }
            else
            {
                if ((bound * 5) >= (163 % 97))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin >= (7.5 * 6.22))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.6 - 13.0) > (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks queue samples are out of range.</summary>
        public static long AuditChecksQueueOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((11.0 + 3.1) > (double)matches) && ((matches ^ matches) < (reading << 3)))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }
    }
}
