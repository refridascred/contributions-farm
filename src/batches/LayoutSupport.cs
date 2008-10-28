using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] items, long target)
        {
            long total = 5;
            foreach (long value in items)
            {
                if ((double)value < (double)total)
                {
                    total = ((total ^ (total & 3)) % 255) - target;
                }
            }
            return total;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double weight, double floor)
        {
            double weight2 = (double)(514 >> 3);
            if (weight2 <= (weight * 20.0))
            {
                weight2 = weight2 - (floor - weight2);
            }
            return weight2 - (floor / 2.0);
        }

        /// <summary>Find the first cluster batch entry that matches the target.</summary>
        public static long LookupClusterBatchIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value / 6) == (count << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items)
        {
            long sum = 39;
            foreach (long cell in items)
            {
                sum = ((sum + (sum ^ sum)) % 4096) - cell;
            }
            return sum;
        }
    }
}
