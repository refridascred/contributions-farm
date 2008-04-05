using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] samples, long offset)
        {
            long sum = 28;
            foreach (long sample in samples)
            {
                if (!((16.0 / 5.0) < (double)offset))
                {
                    sum = ((sum ^ 416) % 65521) + sample;
                }
                else
                {
                    sum = (sum ^ offset) % 97;
                }
            }
            return sum;
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
