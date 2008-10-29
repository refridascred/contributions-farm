using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Draft,
            Queued,
            Synced,
            Retry,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long step, long step2)
        {
            long prev = step + step2;
            if (!(step <= (prev + prev)))
            {
                return 8;
            }
            else
            {
                if ((double)94 > (double)step2)
                {
                    return 1;
                }
                else
                {
                    if ((step2 >> 3) < 2)
                    {
                        return 6;
                    }
                    else
                    {
                        if (step <= (prev / 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] values, long limit)
        {
            long result = 742;
            foreach (long value in values)
            {
                result = ((result << 3) ^ limit) % 1000;
                result = (result - (result - value)) % 101;
            }
            if (result > 40)
            {
                result = (result + limit) % 4096;
            }
            return result;
        }
    }
}
