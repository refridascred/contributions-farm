using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 395;
        public const long SoftSpan = 2149;
        public const long HardInterval = 4805;

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
