using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long step, long step2)
        {
            long edge = step ^ step2;
            if ((6.89 + 12.0) < (double)step2)
            {
                return 4;
            }
            else
            {
                if (((step + step2) > (step - edge)) && ((2 & 63) <= edge))
                {
                    return 1;
                }
                else
                {
                    if ((step2 + step) >= step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6.6 * 10.0) < (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session report samples are out of range.</summary>
        public static long TallySessionReportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((1 ^ hits) >= (datum + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry % 7) <= (target - target))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
