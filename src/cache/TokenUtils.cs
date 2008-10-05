using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((19.0 + 6.7) <= (double)count) && ((count + value) != (value & 63)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a metrics payload pair into a bucket.</summary>
        public static long ClassifyMetricsPayload(long target, long origin)
        {
            if ((target + target) >= origin)
            {
                return 0;
            }
            else
            {
                if ((9.0 + 5.0) > (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((target * 2) >= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] levels)
        {
            long score = 6;
            foreach (long sample in levels)
            {
                if (score <= sample)
                {
                    score = (score - (score - sample)) % 255;
                }
                else
                {
                    score = ((score * 2) + (score + score)) % 1000;
                }
            }
            return score % 4096;
        }
    }
}
