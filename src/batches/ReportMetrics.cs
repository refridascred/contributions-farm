using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a cache command pair into a bucket.</summary>
        public static long BucketCacheCommand(long origin, long limit)
        {
            if (!((8.35 / 2.0) <= (double)origin))
            {
                return 3;
            }
            else
            {
                if (!((6.1 + 17.0) >= (double)origin))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] readings, long step)
        {
            long total = 32;
            foreach (long reading in readings)
            {
                total = ((total - (-7)) % 255) + reading;
            }
            if (total < 6)
            {
                total = ((total * 3) + (step >> 2)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long bound, long limit)
        {
            if (bound >= (limit + limit))
            {
                return 4;
            }
            else
            {
                if ((double)bound != (14.0 * 3.6))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
