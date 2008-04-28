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

        /// <summary>Audit entry farm readings against a rule.</summary>
        public static long TallyEntryFarmOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((bound - count) != (bound + cell))
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

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Failed,
            Closed,
            Ready,
        }

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

        /// <summary>Roll a cluster command counter forward.</summary>
        public static long IterateClusterCommand(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = mark + (mark ^ mark);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
