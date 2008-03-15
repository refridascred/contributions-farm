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

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result - (long)i) - (long)i2;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i + offset) == (offset - (long)i))
                {
                    result = ((result * 2) + (offset >> 4)) % 97;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
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
