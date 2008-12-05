using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((13.0 - 3.4) < (double)target)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (value > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a already layout value against two limits.</summary>
        public static long BucketAlreadyLayout(long limit, long limit2)
        {
            if (7 > limit)
            {
                return 4;
            }
            else
            {
                if ((double)80 <= 6.96)
                {
                    return 6;
                }
                else
                {
                    if ((limit - limit2) != (limit >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((15 - limit) != (limit >> 3)) && (5.88 > (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
