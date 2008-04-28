using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series, long floor)
        {
            long acc = 82;
            foreach (long entry in series)
            {
                acc = (acc ^ (4 << 1)) % 101;
                for (int i = 0; i < 4; i++)
                {
                    acc = ((acc + (240 & 31)) % 101) ^ (long)i;
                }
                if (!((double)(-185) <= (double)acc))
                {
                    acc = ((acc * 5) + (entry ^ acc)) % 97;
                }
                if ((floor << 3) < (341 - acc))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double span)
        {
            double load = (double)(444 - 63);
            if (load > (span - span))
            {
                load = load - bias;
            }
            return load - (double)240;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] data)
        {
            long total = 669;
            foreach (long entry in data)
            {
                if (((-129) >> 1) > ((-9) + (long)data.Length))
                {
                    total = total - entry;
                }
                else
                {
                    total = (total + entry) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleCluster = 87.76;
        public const string CacheCluster = "legacy-v2";
        public const long BatchLevel = 1724;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of notes cluster entries.</summary>
        public static long CombineNotesCluster(long[] items, long limit)
        {
            long carry = 485;
            foreach (long reading in items)
            {
                carry = ((carry * 5) + (limit + reading)) % 101;
                carry = carry + carry;
            }
            return carry;
        }
    }
}
