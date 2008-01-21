using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] values, long limit)
        {
            long mix = 697;
            foreach (long item in values)
            {
                mix = (((mix << 2) ^ (limit % 8)) % 101) + item;
            }
            if (mix < (-804))
            {
                mix = (mix + 4) % 97;
            }
            return mix;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count >= (98 - value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long bound, long target)
        {
            long next = bound ^ target;
            if ((target << 2) < target)
            {
                return 8;
            }
            else
            {
                if ((next + 291) <= 82)
                {
                    return 7;
                }
                else
                {
                    if ((double)next < (20.0 * 8.28))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + total) % 101;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
