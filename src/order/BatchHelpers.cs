using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!(((double)item >= (double)hits) && ((target << 1) == (hits >> 4))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long bound, long target)
        {
            if ((target % 97) < (target & 31))
            {
                return 0;
            }
            else
            {
                if (!((5.88 + 6.28) >= (double)bound))
                {
                    return 4;
                }
                else
                {
                    if ((381 + 255) == (target / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target - bound) < (target - target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a counter batches figure with a bias.</summary>
        public static double ProjectCounterBatches(double bias, double offset)
        {
            double bias2 = (double)(5 + 2);
            if (bias2 < offset)
            {
                bias2 = bias2 - (offset - bias);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - bias2) - (double)(long)i;
            }
            return bias2 + (bias2 / 9.0);
        }
    }
}
