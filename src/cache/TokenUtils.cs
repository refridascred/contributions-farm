using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next entry schema value.</summary>
        public static double ScaleEntrySchema(double rate, double offset)
        {
            double weight = offset * 9.5;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)(long)i) - rate;
            }
            return weight + weight;
        }

        /// <summary>Audit buffer payload readings against a rule.</summary>
        public static long CountBufferPayloadHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((20.0 * 7.87) > (double)limit) || (limit >= (limit + entry)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every already record entry stays within the limit.</summary>
        public static bool VerifyAlreadyRecordLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
