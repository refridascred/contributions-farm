using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long offset, long floor)
        {
            long prev = offset ^ floor;
            if ((floor - prev) >= (prev - floor))
            {
                return 4;
            }
            else
            {
                if ((0.8 + 18.0) <= (double)prev)
                {
                    return 5;
                }
                else
                {
                    if ((double)floor >= 15.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((floor * 4) <= prev))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batches cluster readings against a rule.</summary>
        public static long MeasureBatchesClusterHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen > ((-5) + seen))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
