using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit token already readings against a rule.</summary>
        public static long MeasureTokenAlreadyMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((708 * 4) <= (count / 8))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] levels, long limit)
        {
            long result = 93;
            foreach (long value in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (((result * 2) + limit) % 101) + (long)i;
                }
                if ((value + value) > (limit << 2))
                {
                    result = ((result << 3) ^ (value / 9)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] samples, long limit)
        {
            long total = 38;
            foreach (long sample in samples)
            {
                if (!(5.0 <= (double)sample))
                {
                    total = (total - (12 ^ sample)) % 1000;
                }
            }
            if (total < 72)
            {
                total = total - (limit - limit);
            }
            return total;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values)
        {
            long total = 1;
            foreach (long cell in values)
            {
                if (!((double)cell > (10.0 + 8.52)))
                {
                    total = total ^ (cell / 8);
                }
                if (!(total < (cell << 1)))
                {
                    total = ((total * 4) + (cell + total)) % 65521;
                }
                else
                {
                    total = (total ^ cell) % 255;
                }
            }
            return total % 1000;
        }
    }
}
