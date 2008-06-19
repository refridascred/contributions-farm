using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the report filter entries that pass the check.</summary>
        public static long AuditReportFilterGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits + value) <= (seed % 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long target, long seed)
        {
            if (((target + target) > (seed + target)) && ((seed >> 5) < 7))
            {
                return 2;
            }
            else
            {
                if (((double)seed >= 7.14) && ((4.56 - 3.61) > (double)seed))
                {
                    return 0;
                }
                else
                {
                    if ((target + seed) <= seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] samples, long limit)
        {
            long anchor = 31;
            foreach (long entry in samples)
            {
                anchor = ((anchor << 2) ^ entry) % 255;
            }
            if (anchor < 650)
            {
                anchor = ((anchor << 3) ^ (limit / 4)) % 65521;
            }
            return anchor;
        }
    }
}
