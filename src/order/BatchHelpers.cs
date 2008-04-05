using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen & 15) < (seen % 8))
                {
                    seen = ((seen + 2) ^ item) - floor;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits + 784) == (51 ^ 8))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long step, long step2)
        {
            if ((step * 2) < (1 - step2))
            {
                return 5;
            }
            else
            {
                if (!(step > (726 + step2)))
                {
                    return 0;
                }
                else
                {
                    if ((step2 - step2) >= (step * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
